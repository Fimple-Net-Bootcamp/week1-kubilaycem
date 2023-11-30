using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Abstraction
{
    public abstract class LendingPolicy
    {
        public abstract string PolicyName { get; }

        public abstract void ApplyPolicy(Member member, Book book);
    }

   

   
}
