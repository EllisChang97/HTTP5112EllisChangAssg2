using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112EllisChangAssg2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Tells you how many combinations of two die with side numbers of m and n respectively can give a sum of 10
        /// </summary>
        ///<returns>A string stating the number of combinations that result in a sum of 10</returns>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <example>
        /// GET: /api/J2/DiceGame/6/8 ->
        /// There are 5 total ways to get the sum 10
        /// </example>

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {

            List<int> sumList = new List<int> { };
            List<int> finalList = new List<int> { };

            for (int i = m; i > 0; i--)
            {
                for (int t = n; t > 0; t--)
                {
                    int addNumber = i + t;
                    sumList.Add(addNumber);
                }
            }

            for (int i = sumList.Count; i > 0; i--)
            {
                if (sumList[i - 1] == 10)
                {
                    finalList.Add(sumList[i - 1]);
                }
            }

            int numberOfTens = finalList.Count;
            string finalStatement = "There are " + numberOfTens + " total ways to get the sum 10";

            return finalStatement;

        }
    }
}