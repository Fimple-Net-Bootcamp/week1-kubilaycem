using LibraryManagementSystem.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class ShortTermLendingPolicy : LendingPolicy
    {
        public override string PolicyName => "Short Term Lending Policy";

        public override void ApplyPolicy(Member member, Book book)
        {
            // Kısa süreli ödünç verme politikası uygulama
            Console.WriteLine($"'{book.Title}' kitabı, {member.FirstName} {member.LastName}'e kısa süreli olarak ödünç verildi.");
        }
    }
}
