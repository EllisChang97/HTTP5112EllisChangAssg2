using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace HTTP5112EllisChangAssg2.Controllers
{
    public class J3Controller : ApiController
    {

        /// <summary>
        /// Gives all the distances between each of the 5 cities on the road trip when the distances between consecutive cities is inputted
        /// </summary>
        /// <return>A grid with each row representing the distance to each city from the ith city (row i = city i)</return>
        /// <param name="distone"></param>
        /// <param name="disttwo"></param>
        /// <param name="distthree"></param>
        /// <param name="distfour"></param>
        /// <example>
        /// GET: /api/J3/RoadTrip/3/10/12/5 ->
        /// 0 3 13 25 30
        /// 3 0 10 22 27
        /// 13 10 0 12 17
        /// 25 22 12 0 5
        /// 30 27 17 5 0
        /// </example>
       

        /// I attempted to have the output formatted as a grid by converting all the List<int> (firstLine, secondLine etc.) into strings. 
        /// Then I would add those strings into another List of strings so that the output would be in a grid format.
        /// I also know that there must exist a more efficient method to solve this problem. One where the code is able to output all possible distances regardless of the number of cities on the trip.
        
        [HttpGet]
        [Route("api/J3/RoadTrip/{distone}/{disttwo}/{distthree}/{distfour}")]
        public List<List<int>> RoadTrip(int distone, int disttwo, int distthree, int distfour)
        {
            List<int> firstLine = new List<int> { };
            List<int> secondLine = new List<int> { };
            List<int> thirdLine = new List<int> { };
            List<int> fourthLine = new List<int> { };
            List<int> fifthLine = new List<int> { };

            for (int i = 1; i <= 5; i++)
            {
                if (i == 1)
                {
                    int distance = 0;
                    firstLine.Add(distance);
                }
                else if (i == 2)
                {
                    int distance = distone;
                    firstLine.Add(distance);
                }
                else if (i == 3)
                {
                    int distance = distone + disttwo;
                    firstLine.Add(distance);
                }
                else if (i == 4)
                {
                    int distance = distone + disttwo + distthree;
                    firstLine.Add(distance);
                }
                else if (i == 5)
                {
                    int distance = distone + disttwo + distthree + distfour;
                    firstLine.Add(distance);
                }
            }


            for (int i = 1; i <= 5; i++)
            {
                if (i == 1)
                {
                    int distance = distone;
                    secondLine.Add(distance);
                }
                else if (i == 2)
                {
                    int distance = 0;
                    secondLine.Add(distance);
                }
                else if (i == 3)
                {
                    int distance = disttwo;
                    secondLine.Add(distance);
                }
                else if (i == 4)
                {
                    int distance = disttwo + distthree;
                    secondLine.Add(distance);
                }
                else if (i == 5)
                {
                    int distance = disttwo + distthree + distfour;
                    secondLine.Add(distance);
                }
            }


            for (int i = 1; i <= 5; i++)
            {
                if (i == 1)
                {
                    int distance = distone + disttwo;
                    thirdLine.Add(distance);
                }
                else if (i == 2)
                {
                    int distance = disttwo;
                    thirdLine.Add(distance);
                }
                else if (i == 3)
                {
                    int distance = 0;
                    thirdLine.Add(distance);
                }
                else if (i == 4)
                {
                    int distance = distthree;
                    thirdLine.Add(distance);
                }
                else if (i == 5)
                {
                    int distance = distthree + distfour;
                    thirdLine.Add(distance);
                }
            }


            for (int i = 1; i <= 5; i++)
            {
                if (i == 1)
                {
                    int distance = distone + disttwo + distthree;
                    fourthLine.Add(distance);
                }
                else if (i == 2)
                {
                    int distance = disttwo + distthree;
                    fourthLine.Add(distance);
                }
                else if (i == 3)
                {
                    int distance = distthree;
                    fourthLine.Add(distance);
                }
                else if (i == 4)
                {
                    int distance = 0;
                    fourthLine.Add(distance);
                }
                else if (i == 5)
                {
                    int distance = distfour;
                    fourthLine.Add(distance);
                }
            }


            for (int i = 1; i <= 5; i++)
            {
                if (i == 1)
                {
                    int distance = distone + disttwo + distthree + distfour;
                    fifthLine.Add(distance);
                }
                else if (i == 2)
                {
                    int distance = disttwo + distthree + distfour;
                    fifthLine.Add(distance);
                }
                else if (i == 3)
                {
                    int distance = distthree + distfour;
                    fifthLine.Add(distance);
                }
                else if (i == 4)
                {
                    int distance = distfour;
                    fifthLine.Add(distance);
                }
                else if (i == 5)
                {
                    int distance = 0;
                    fifthLine.Add(distance);
                }
            }

            List<List<int>> wholeGrid = new List<List<int>> { };

            wholeGrid.Add(firstLine);
            wholeGrid.Add(secondLine);
            wholeGrid.Add(thirdLine);
            wholeGrid.Add(fourthLine);
            wholeGrid.Add(fifthLine);

            return wholeGrid;
        }
    }
}


