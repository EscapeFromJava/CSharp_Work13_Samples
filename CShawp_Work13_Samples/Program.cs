using System.Collections.Generic;
using System.IO;

namespace CShawp_Work13_Samples
{
    class Program
    {
        static void Main()
        {
            string input = @"INPUT.txt";
            string[] array = File.ReadAllLines(input);
            char[] first = array[0].ToCharArray();
            char[] second = array[1].ToCharArray();

            List<string> firstList = new List<string>();
            List<string> secondList = new List<string>();

            FillingList(first, firstList);
            FillingList(second, secondList);

            List<string> finallyFirst = new List<string>();
            List<string> finallySecond = new List<string>();

            if (firstList.Count == 1)
            {
                Combo1(firstList, finallyFirst);
                Combo1(secondList, finallySecond);
            }
            else if (firstList.Count == 2)
            {
                Combo2(firstList, finallyFirst);
                Combo2(secondList, finallySecond);
            }
            else if (firstList.Count == 3)
            {
                Combo3(firstList, finallyFirst);
                Combo3(secondList, finallySecond);
            }
            else if (firstList.Count == 4)
            {
                Combo4(firstList, finallyFirst);
                Combo4(secondList, finallySecond);
            }
            else if (firstList.Count == 5)
            {
                Combo5(firstList, finallyFirst);
                Combo5(secondList, finallySecond);
            }
            else if (firstList.Count == 6)
            {
                Combo6(firstList, finallyFirst);
                Combo6(secondList, finallySecond);
            }
            else if (firstList.Count == 7)
            {
                Combo7(firstList, finallyFirst);
                Combo7(secondList, finallySecond);
            }
            else if (firstList.Count == 8)
            {
                Combo8(firstList, finallyFirst);
                Combo8(secondList, finallySecond);
            }
            else if (firstList.Count == 9)
            {
                Combo9(firstList, finallyFirst);
                Combo9(secondList, finallySecond);
            }

            int count = 0;
            foreach (var el in finallyFirst)
            {
                if (finallySecond.Contains(el))
                    count++;
            }

            string result = count.ToString();
            string output = @"OUTPUT.txt";
            File.WriteAllText(output, result);
        }

        static void FillingList(char[] arr, List<string> list)
        {
            foreach (var el in arr)
            {
                if (el == '0')
                    list.Add("0");
                else if (el == '1')
                    list.Add("1");
                else if (el == '2')
                    list.Add("2");
                else if (el == '3')
                    list.Add("3");
                else if (el == '4')
                    list.Add("4");
                else if (el == '5')
                    list.Add("5");
                else if (el == '6')
                    list.Add("6");
                else if (el == '7')
                    list.Add("7");
                else if (el == '8')
                    list.Add("8");
                else if (el == '9')
                    list.Add("9");
                else if (el == 'a')
                    list.Add("0123");
                else if (el == 'b')
                    list.Add("1234");
                else if (el == 'c')
                    list.Add("2345");
                else if (el == 'd')
                    list.Add("3456");
                else if (el == 'e')
                    list.Add("4567");
                else if (el == 'f')
                    list.Add("5678");
                else if (el == 'g')
                    list.Add("6789");
                else if (el == '?')
                    list.Add("0123456789");
            }
        }

        static void Combo1(List<string> listIn, List<string> listOut)
        {
            for (int i = 0; i < listIn[0].Length; i++)
            {
                string temp = listIn[0][i].ToString();
                listOut.Add(temp);
            }
        }

        static void Combo2(List<string> listIn, List<string> listOut)
        {
            for (int i = 0; i < listIn[0].Length; i++)
            {
                for (int j = 0; j < listIn[1].Length; j++)
                {
                    string temp = listIn[0][i].ToString() + listIn[1][j].ToString();
                    listOut.Add(temp);
                }
            }
        }

        static void Combo3(List<string> listIn, List<string> listOut)
        {
            for (int i = 0; i < listIn[0].Length; i++)
            {
                for (int j = 0; j < listIn[1].Length; j++)
                {
                    for (int k = 0; k < listIn[2].Length; k++)
                    {
                        string temp = listIn[0][i].ToString() + listIn[1][j].ToString() + listIn[2][k].ToString();
                        listOut.Add(temp);
                    }
                }
            }
        }

        static void Combo4(List<string> listIn, List<string> listOut)
        {
            for (int i = 0; i < listIn[0].Length; i++)
            {
                for (int j = 0; j < listIn[1].Length; j++)
                {
                    for (int k = 0; k < listIn[2].Length; k++)
                    {
                        for (int l = 0; l < listIn[3].Length; l++)
                        {
                            string temp = listIn[0][i].ToString() + listIn[1][j].ToString() + listIn[2][k].ToString() +
                                          listIn[3][l].ToString();
                            listOut.Add(temp);
                        }
                    }
                }
            }
        }

        static void Combo5(List<string> listIn, List<string> listOut)
        {
            for (int i = 0; i < listIn[0].Length; i++)
            {
                for (int j = 0; j < listIn[1].Length; j++)
                {
                    for (int k = 0; k < listIn[2].Length; k++)
                    {
                        for (int l = 0; l < listIn[3].Length; l++)
                        {
                            for (int m = 0; m < listIn[4].Length; m++)
                            {
                                string temp = listIn[0][i].ToString() + listIn[1][j].ToString() +
                                              listIn[2][k].ToString() + listIn[3][l].ToString() +
                                              listIn[4][m].ToString();
                                listOut.Add(temp);
                            }
                        }
                    }
                }
            }
        }

        static void Combo6(List<string> listIn, List<string> listOut)
        {
            for (int i = 0; i < listIn[0].Length; i++)
            {
                for (int j = 0; j < listIn[1].Length; j++)
                {
                    for (int k = 0; k < listIn[2].Length; k++)
                    {
                        for (int l = 0; l < listIn[3].Length; l++)
                        {
                            for (int m = 0; m < listIn[4].Length; m++)
                            {
                                for (int n = 0; n < listIn[5].Length; n++)
                                {
                                    string temp = listIn[0][i].ToString() + listIn[1][j].ToString() +
                                                  listIn[2][k].ToString() + listIn[3][l].ToString() +
                                                  listIn[4][m].ToString() + listIn[5][n].ToString();
                                    listOut.Add(temp);
                                }
                            }
                        }
                    }
                }
            }
        }

        static void Combo7(List<string> listIn, List<string> listOut)
        {
            for (int i = 0; i < listIn[0].Length; i++)
            {
                for (int j = 0; j < listIn[1].Length; j++)
                {
                    for (int k = 0; k < listIn[2].Length; k++)
                    {
                        for (int l = 0; l < listIn[3].Length; l++)
                        {
                            for (int m = 0; m < listIn[4].Length; m++)
                            {
                                for (int n = 0; n < listIn[5].Length; n++)
                                {
                                    for (int o = 0; o < listIn[6].Length; o++)
                                    {
                                        string temp = listIn[0][i].ToString() + listIn[1][j].ToString() +
                                                      listIn[2][k].ToString() + listIn[3][l].ToString() +
                                                      listIn[4][m].ToString() + listIn[5][n].ToString() +
                                                      listIn[6][o].ToString();
                                        listOut.Add(temp);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        static void Combo8(List<string> listIn, List<string> listOut)
        {
            for (int i = 0; i < listIn[0].Length; i++)
            {
                for (int j = 0; j < listIn[1].Length; j++)
                {
                    for (int k = 0; k < listIn[2].Length; k++)
                    {
                        for (int l = 0; l < listIn[3].Length; l++)
                        {
                            for (int m = 0; m < listIn[4].Length; m++)
                            {
                                for (int n = 0; n < listIn[5].Length; n++)
                                {
                                    for (int o = 0; o < listIn[6].Length; o++)
                                    {
                                        for (int p = 0; p < listIn[7].Length; p++)
                                        {
                                            string temp = listIn[0][i].ToString() + listIn[1][j].ToString() +
                                                          listIn[2][k].ToString() + listIn[3][l].ToString() +
                                                          listIn[4][m].ToString() + listIn[5][n].ToString() +
                                                          listIn[6][o].ToString() + listIn[7][p].ToString();
                                            listOut.Add(temp);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        static void Combo9(List<string> listIn, List<string> listOut)
        {
            for (int i = 0; i < listIn[0].Length; i++)
            {
                for (int j = 0; j < listIn[1].Length; j++)
                {
                    for (int k = 0; k < listIn[2].Length; k++)
                    {
                        for (int l = 0; l < listIn[3].Length; l++)
                        {
                            for (int m = 0; m < listIn[4].Length; m++)
                            {
                                for (int n = 0; n < listIn[5].Length; n++)
                                {
                                    for (int o = 0; o < listIn[6].Length; o++)
                                    {
                                        for (int p = 0; p < listIn[7].Length; p++)
                                        {
                                            for (int q = 0; q < listIn[8].Length; q++)
                                            {
                                                string temp = listIn[0][i].ToString() + listIn[1][j].ToString() +
                                                              listIn[2][k].ToString() + listIn[3][l].ToString() +
                                                              listIn[4][m].ToString() + listIn[5][n].ToString() +
                                                              listIn[6][o].ToString() + listIn[7][p].ToString() +
                                                              listIn[8][q].ToString();
                                                listOut.Add(temp);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}