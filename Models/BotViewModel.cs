using System;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms;
using Microsoft.ML.Trainers;
using Microsoft.ML.Runtime.Api;
using Microsoft.ML.Runtime.Data;
using Microsoft.ML.Runtime.Internal;
using Microsoft.ML.Runtime.Internal.Internallearn;
using Microsoft.ML.Runtime.Learners;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Microsoft.ML.Core.Data;

namespace dotnetcoreMVC.Models
{
        public class FAQData{
        [Column("0")][ColumnName("Question")]
        public string Question {get; set;}
        [Column("1")]
        [ColumnName("Label")]
        public int Answer {get;set;}
    }

    public class AnswerPrediction
    {
        [ColumnName("Label")]
        public int Answer;
        [ColumnName("Score")]
        public float[] Score { get; set; }
    }
    public class BotViewModel
    {
        List<string> Answers
        {
            get;
            set;
        }

        MLContext mlContext;

        public BotViewModel()
        {
            mlContext = new MLContext();
            Answers = new List<string>();
                Answers.Add("property address and the new mailing address.");
                Answers.Add("Yes, be sure to make the money order payable to the Association and make sure your account number is written on it.");
                Answers.Add("The account number can be found on your statement. If you no longer have your account number you may contact our office to obtain it.");
                Answers.Add("Yes, pay online using a credit card by going to www.crest-management.com and following the \"Pay Assessments\" link to your association. You will need your account number in order to make a payment. There is a $14.95 fee to pay with a credit card. This fee is paid to the credit card processing company not to the association or Crest.");
                Answers.Add("Yes, a payment using an eCheck can be made online by going to www.crest-management.com and; following the \"Pay Assessments\" link to your association. You will need your account number in-order to make a payment. There is no fee to pay with an eCheck.");
                Answers.Add("No, but paying online is available");
                Answers.Add("Yes just contact our office");
                Answers.Add("Mail your payment to: <Association Name>  c/o Crest Management Inc. PO Box  219320 Houston, Texas 77218");
                Answers.Add("17171 Park Row, Suite 310, Houston, Texas 77084  office hours are 9 AM - 5 PM, closed on Fridays .from Noon - 1 PM. Please note: If you plan to pay in person please remember that we cannot accept cash or credit you must pay with a check or money order.");
                Answers.Add("Please contact our office.");
                Answers.Add("Please send an email to your account rep. The email should include the name of the association, the property address and the new mailing address.");
        }
        public BotAnswerModel Predict(string Question)
        {
            BotAnswerModel answer = new BotAnswerModel();
            ITransformer model = null;
            using(FileStream stream = new FileStream("~/Models/crestmodel.zip", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Console.WriteLine("Loading file");
                model = mlContext.Model.Load(stream);
            }
            
            var predictionFunc = mlContext.CreatePredictionEngine<FAQData, AnswerPrediction>(model);
            
            var q = new FAQData()
            {
                Question = Question
            };

            AnswerPrediction prediction = predictionFunc.Predict(q);

            foreach (float score in prediction.Score)
            {
                Console.WriteLine(score * 100);
            }

            float maxValue = prediction.Score.Max();
            
            answer.confidence = maxValue.ToString();
            answer.answer = Answers[prediction.Score.ToList().IndexOf(maxValue)];
            return answer;
        }
    }
}