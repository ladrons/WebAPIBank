using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIBank.Models.Context;
using WebAPIBank.Models.Entities;

namespace WebAPIBank.DesignPatterns.Strategy
{
    public class MyInit:CreateDatabaseIfNotExists<MyContext>
    {
        // AŞAĞIDAKİ VERİ TEST VERİSİDİR. HERHANGİ BİR GERÇEKLİK PAYI YOKTUR !

        protected override void Seed(MyContext context)
        {
            CardInformation ci = new CardInformation();

            ci.CardUserName = "Sedat Uçan";
            ci.CardNumber = "1111 0000 1111 0000";
            ci.CardExpiryYear = 2024;
            ci.CardExpiryMonth = 10;
            ci.SecurityNumber = "123";
            ci.Limit = 50000;
            ci.Balance = 50000;

            context.Cards.Add(ci);
            context.SaveChanges();
        }
    }
}