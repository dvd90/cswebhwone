using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//David Sellam
//328031281

namespace homeworkOne.Controllers
{
    [Route("api/[controller]")]
    public class HomeworkController : Controller
    {
        // HomeworkOne
        [HttpGet("")]
        public string Get()
        {
            return "Here is my list of homework exercises: 5, 7, 13, 15, 19";
        }

        // Exercice 5
        [HttpGet("words_checker")]
        public bool Get(string word1, string word2)
        {
            if (word1 == null || word2 == null)
            {
                return false;
            }
            return word1.ToLower().Equals(word2.ToLower());
        }

        // Exercice 7
        [HttpGet("letter_counter")]
        public string Get(string sentence)
        {
            if (sentence == null)
            {
                return "Please input a sentence";
            }
            string buffer = "";
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                buffer += word.Length.ToString() + "  ";
            }
            return buffer;
        }

        // Exercice 13
        [HttpGet("calculator")]
        public int[] Get(int? n1, int? n2)
        {
            if (n1.HasValue && n2.HasValue)
            {
                int[] res = { (int)(n1 + n2), (int)(n1 - n2), (int)(n1 * n2), (int)(n1 / n2) };
                return res;
            }
            else
            {
                return new int[] { -1 };
            }
        }

        // Exercice 15
        [HttpGet("max_number")]
        public int Get(int? n1, int? n2, int? n3)
        {
            if (n1.HasValue && n2.HasValue && n3.HasValue)
            {
                int max = (int)(n1 >= n2 ? n1 : n2);
                max = (int)(max >= n3 ? max : n3);
                return max;
            }
            else
            {
                return -1;
            }
        }

        // Exercice 19
        [HttpGet("reverse_counter")]
        public int[] Get(int? n)
        {
            if (!(n.HasValue) || n == 0)
            {
                return new int[] { -1 };
            }
            int number = (int)(n - 1);
            int[] counter = new int[number];
            for (int i = 0; i < (int)(n - 1); i++)
            {
                counter[i] = number;
                number--;
            }
            return counter;
        }
    }
}