using PracticeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeMVC.Service
{
    public class AccountBookAPI
    {
        private static ModelContext _context = new ModelContext();

        public static List<Records> GetData()
        {
            var query = from q in _context.AccountBooks
                        select new Records
                        {
                            ID = q.Id,
                            Type = q.Categoryyy,
                            Date = q.Dateee,
                            Amount = q.Amounttt,
                        };

            return query.ToList();
        }
    }
}