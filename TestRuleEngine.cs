using BusinessRulesEngine;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            List<IPurchaseRule> payments = new List<IPurchaseRule>();
            payments.Add(new DuplicatePackingSlipRule());
            payments.Add(new CommissionPaymentRule());
            OrderProcessor processor = new OrderProcessor(payments);
            Product product = new BookProduct();
            processor.ProcessOrder(product);
            Assert.Pass();
        }
    }
}