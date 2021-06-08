using System;

namespace _14.JaggedArray.Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[][]
            {
                new int[] {1 ,2 ,3 },
                new int[] {4 ,5 ,6, 7, 8 },
                new int[] {9 ,10 ,11 ,12, 13 }
            };

            var array2 = new int[4][][] //[4][][]=>[4] - [][]
            {
                new int[2][]{ //[2][] => [2] - []                
                    new int[]{},
                    new int[]{}
                },
                new int[1][]{
                    new int[]{}
                },
                new int[][]{
                    new int[]{},
                    new int[]{},
                    new int[]{},
                    new int[2]{ 1, 2 }
                },
                new int[][]{ }
            };

            var array3 = new int[2, 4][] //[2,4][] => [2,4] - []
            {
                {
                  new int[]{ }, new int[]{ },  new int[]{ }, new int[]{ }
                },
                {
                  new int[]{ }, new int[]{ }, new int[]{ }, new int[]{ }
                }
            };

            var array4 = new int[2, 4][][] //[2,4][][] => [2,4]-[][] 
            {
                {
                    new int[][]{ }, new int[][]{ }, new int[][]{ }, new int[][]{ }
                },
                {
                    new int[][]{ },
                    new int[][]{ },
                    new int[][]{ },
                    new int[5][]{ //[5][] => [5] - []
                      new int[]{ },
                      new int[]{ },
                      new int[]{ },
                      new int[]{ },
                      new int[5]{
                        1, 2, 3, 4, 5
                      }
                    }
                }
            };

            var array5 = new int[3][,]//[3][,] => [3] - [,]
            {
                new int[,]{ },
                new int[,]{ },
                new int[2, 4]{
                  { 1, 2, 3, 4 },
                  { 5, 6, 7, 8 }
                }
            };

            var array6 = new int[3, 4][][,,] //[3, 4][][,,] => [3, 4] - [][,,]
            {
                {
                    new int[][,,]{ },
                    new int[][,,]{ },
                    new int[][,,]{ },
                    new int[][,,]{ }
                },
                {
                    new int[][,,]{ },
                    new int[][,,]{ },
                    new int[][,,]{ },
                    new int[][,,]{ }
                },
                {
                    new int[][,,]{ },
                    new int[][,,]{ },
                    new int[][,,]{ },
                    new int[6][,,]{ //[6][,,] => [6] - [,,]
                        new int[,,] { },
                        new int[,,] { },
                        new int[,,] { },
                        new int[,,] { },
                        new int[,,] { },
                        new int[2, 3, 4] {
                            {
                                { 1, 2, 3, 4 },
                                { 1, 2, 3, 4 },
                                { 1, 2, 3, 4 }
                            },
                            {
                                { 1, 2, 3, 4 },
                                { 1, 2, 3, 4 },
                                { 1, 2, 3, 4 }
                            }
                        }
                    }
                },
            };

            var array7 = new int[2, 4][,][] //[2, 4][,][] => [2, 4] - [,][]
            {
                {
                    new int[,][]{ },
                    new int[,][]{ },
                    new int[,][]{ },
                    new int[,][]{ }
                },
                {
                    new int[,][]{ },
                    new int[,][]{ },
                    new int[,][]{ },
                    new int[2,2][]{ //[2, 2][] => [2, 2] - []
                        {
                            new int[]{ },
                            new int[]{ }
                        },
                        {
                            new int[]{ },
                            new int[5]{
                                1, 2, 3, 4, 5
                            }
                        },
                    }
                },
            };

        }
    }
}
