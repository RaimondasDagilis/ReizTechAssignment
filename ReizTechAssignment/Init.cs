using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReizTechAssignment
{
    public class Init
    {
        private Branch branches = new Branch()
        {
            branches = new List<Branch>() {
                new Branch() {
                    branches = new List<Branch>() {
                        new Branch() {
                            branches = null
                        }
                    }
                },
                new Branch() {
                    branches = new List<Branch>() {
                        new Branch() {
                            branches = new List<Branch>() {
                                new Branch() {
                                    branches = null
                                }
                            }
                        },
                        new Branch() {
                            branches = new List<Branch> {
                                new Branch() {
                                    branches = new List<Branch>() {
                                        new Branch() {
                                            branches = null
                                        }
                                    }
                                },
                                new Branch() {
                                    branches = null
                                }
                            }
                        },
                        new Branch() {
                            branches = null
                        }
                    }
                }
            }
        };

        private Calculations calculations;
        private DepthSearch depthSearch;
        public Init()
        {
            calculations = new Calculations();
            depthSearch = new DepthSearch();
        }
        public void StartDegreeCalculation()
        {
            Console.Clear();
            Console.WriteLine("Task 1 : ");
            string input;
            double angle;
            do
            {
                input = calculations.GetData();
                if (input != "")
                {
                    angle = calculations.CalculateAngle(input);
                    Console.WriteLine($"Lesser angle between arrows in degrees : {angle}");
                }
            } while (input != "");


        }
        public void StartDepthSearch()
        {
            Console.Clear();
            Console.WriteLine("Task 2 : ");
            int depth = 0;
            if (branches != null)
            {
                depth = depthSearch.GoDeeper(branches.branches, 1);
            }
            Console.WriteLine($"Max depth of a tree : {depth}");
        }
    }
}
