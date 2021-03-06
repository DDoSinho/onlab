﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal.Entities;
using Dal;

namespace Web.Services
{
    public class QuizService : IQuizService
    {
        private readonly QuestionManager _questionManager;

        public QuizService(QuestionManager questionManager)
        {
            _questionManager = questionManager;
        }
        //asd
        public IEnumerable<Quiz> GetQuizs()
        {
            string asd;
            return _questionManager.GetQuizs();
        }
    }
}
