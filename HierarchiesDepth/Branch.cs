using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchiesDepth
{
    internal class Branch
    {
        public List<Branch> branches = new List<Branch>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="branch"></param>
        /// <returns></returns>
        public static int CalculateDepth(Branch branch)
        {
            var branchesDepthsList = new List<int>();

            if (branch.branches.Count == 0)
            {
                return 1;
            }
            foreach (Branch childBranch in branch.branches)
            {
                branchesDepthsList.Add(CalculateDepth(childBranch));
            }
            return branchesDepthsList.Max() + 1;
        }
    }
}