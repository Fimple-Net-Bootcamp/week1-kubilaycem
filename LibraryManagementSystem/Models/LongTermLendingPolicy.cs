using LibraryManagementSystem.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class LongTermLendingPolicy : LendingPolicy
    {
        public override string PolicyName => "Long Term Lending Policy";

        public override void ApplyPolicy(Member member, Book book)
        {
            // Uzun süreli ödünç verme politikası uygulama
            Console.WriteLine($"'{book.Title}' kitabı, {member.FirstName} {member.LastName}'e uzun süreli olarak ödünç verildi.");
        }
    }
}
