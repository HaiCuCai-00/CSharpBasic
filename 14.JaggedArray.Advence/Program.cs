using System;

namespace _14.JaggedArray.Advence
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[][]
            {
                new int [] {1, 2, 3},
                new int [] {4, 5, 6, 7, 8},
                new int [] {9, 10, 11, 12, 13}
             };

            var array2 = new int[4][][] // [a][][] => [a] - [][]
            {
                new int [2][]{
                    new int []{},
                    new int []{}
                             },
                new int [][]{
                    new int []{}
                            },
                new int [][]{
                             new int []{},
                             new int []{},
                             new int []{}
                            },
                new int [][]{},
            };

            var array3 = new int[2, 4][] // [2, 4][] => [2, 4] - []
            {
                {
                    new int []{}, new int []{}, new int []{}, new int []{}
                },
                {
                    new int []{}, new int []{}, new int []{}, new int []{}
                },
            };

            var array4 = new int[2, 4][][] // [2][4][][] => 
            {
                {
                    new int [][]{}, new int [][]{}, new int [][]{}, new int [2][]{ // [a][] => []
                                                                            new int[] {},
                                                                            new int[] {},
                                                                                  } 
                },
                {
                    new int [][]{}, new int [][]{}, new int [][]{}, new int [][]{}
                },
            };

            var array5 = new int[3][,] // [a][,] => [a] - [,]
            {
                new int [,]{},
                new int [,]{},
                new int [2, 4]{ // [a, b] => có a hàng và b cột
                              {1, 2, 3, 4 },
                              {5, 6, 7, 8 }
                              },
            };

            var array6 = new int[3, 4][][,,] // [3, 4][][,,] => [3, 4] - [][,,]
            {
                { 
                    new int [][,,]{ },
                    new int [][,,]{ },
                    new int [][,,]{ },
                    new int [][,,]{ }
                },
                {
                    new int [][,,]{ },
                    new int [][,,]{ },
                    new int [][,,]{ },
                    new int [][,,]{ }
                },
                {
                    new int [][,,]{ },
                    new int [][,,]{ },
                    new int [][,,]{ },
                    new int [6 ][,,]{ // [6]{,,} => [6] - {,,}
                                        new int [,,] {},
                                        new int [,,] {},
                                        new int [,,] {},
                                        new int [,,] {},
                                        new int [,,] {},
                                        new int [2 , 3, 4] { // 2 hàng 3 cột 4 phần tử 
                                            { {1, 2, 3, 4 }, {5, 6, 7, 8 }, {9, 10, 11,12 } },
                                            { {21,22,34,44}, {23, 44, 44,22}, {23,13, 23,23} }
                                                           }
                                    }
                }
            };

            var array7 = new int[2, 4][,][] // [2, 4][,][] => [2, 4] - [,][]
            {
                {
                    new int [,][] {},
                    new int [,][] {},
                    new int [,][] {},
                    new int [,][] {},
                },
                {
                    new int [,][] {},
                    new int [,][] {},
                    new int [,][] {},
                    new int [,][] {},
                }

            };
        }
    }
}
