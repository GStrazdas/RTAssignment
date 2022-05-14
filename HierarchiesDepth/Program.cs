/****************************************************************************************************************
 *      Please write a program, where you would create similar structure. Pass this structure into your own     *
 *      created method and calculate the depth of provided structure. Main requirement to complete this         *
 *      task: use recursion.                                                                                    *
 ****************************************************************************************************************/

using HierarchiesDepth;

var branch = new Branch()
{
    branches = {
       new Branch() { branches = {
           new Branch() }
       },
       new Branch() { branches = {
           new Branch() {branches = {
               new Branch() }
           },
           new Branch() {branches = {
               new Branch() {branches = {
                   new Branch() }
               },
               new Branch() }
           },
           new Branch() }
       }
    }
};

Console.WriteLine($"Structures depth is {Branch.CalculateDepth(branch)}.");