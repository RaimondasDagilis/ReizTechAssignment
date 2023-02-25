using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTechAssignment
{
    public class DepthSearch
    {
        private int maxDepth = 0;
        public int GoDeeper(List<Branch> branches, int depth)
        {
            if (branches != null)
            {
                foreach (Branch branch in branches)
                {             
                    GoDeeper(branch.branches, depth + 1);
                }
            }
            else
            {
                if (maxDepth < depth)
                {
                    maxDepth = depth;
                }
            }
            return maxDepth;
        }
    }
}
