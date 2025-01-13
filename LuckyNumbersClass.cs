using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LuckyNumbersClass
    {
        record Position
        {
            public int X { get; set; }
            public int Y { get; set; }

            public int Value { get; set; }

        }


        public int FindLucky(int[] arr)
        {
            var dictionary = new Dictionary<int, int>();

            var index = 0;

            while (index < arr.Length)
            {
                if (dictionary.TryGetValue(arr[index], out var value))
                {
                    dictionary[arr[index]] = ++value;
                }
                else
                {
                    dictionary[arr[index]] = 1;
                }

                index++;
            }

            var maxValue = -1;

            foreach (var key in dictionary.Keys)
            {
                if (dictionary[key] == key && key > maxValue)
                {
                    maxValue = key;
                }
            }

            return maxValue;
        }



        public IList<int> LuckyNumbers(int[][] matrix)
        {
            var response = new List<int>();
            var index = 0;

            var minimunValueArray = new Position[matrix.Length];
            var maximunValueArray = new Position[matrix[0].Length];

            while (index < matrix.Length)
            {
                minimunValueArray[index++] = new Position
                {
                    Value = int.MaxValue
                };
            }

            index = 0;

            while (index < matrix[0].Length)
            {
                maximunValueArray[index++] = new Position
                {
                    Value = int.MinValue
                };
            }

            index = 0;

            while (index < matrix.Length)
            {
                var row = matrix[index];
                var indexJ = 0;

                while (indexJ < row.Length)
                {
                    var number = row[indexJ];
                    if (number < minimunValueArray[index].Value)
                    {
                        minimunValueArray[index].Value = number;
                        minimunValueArray[index].X = index;
                        minimunValueArray[index].Y = indexJ;

                    }

                    if (number > maximunValueArray[indexJ].Value)
                    {
                        maximunValueArray[indexJ].Value = number;
                        maximunValueArray[indexJ].X = index;
                        maximunValueArray[indexJ].Y = indexJ;
                    }

                    indexJ++;
                }

                index++;
            }

            var dictionary = new Dictionary<int, Position>();

            foreach (var item in maximunValueArray)
            {
                dictionary[item.Value] = item;
            }

            foreach (var item in minimunValueArray)
            {
                if (dictionary.TryGetValue(item.Value, out var value) && value.X == item.X && value.Y == item.Y)
                {
                    response.Add(item.Value);
                }
            }


            return response;
        }
    }
}
