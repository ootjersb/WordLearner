using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WordLearnerMVC.Models;

namespace WordLearnerMVC.Controllers
{
    public class PracticeController : Controller
    {
        // GET: Practice
        public ActionResult Index()
        {
            Practice practice = new Practice
            {
                Word = GetWord(),
                Choices = GetChoices()
            };
            return View(practice);
        }
        private List<Word> GetChoices()
        {
            var wordList = new List<Word>();
            wordList.Add(GetWord());
            wordList.Add(GetWord());
            wordList.Add(GetWord());
            wordList.Add(GetWord());
            return wordList;
        }

        private Word GetWord()
        {
            return new Word
            {
                Description = "Description",
                WordID = 1,
                WordType = new WordType
                {
                    Description = "Adverb",
                    WordTypeID = 1
                }
            };
        }

    }
}