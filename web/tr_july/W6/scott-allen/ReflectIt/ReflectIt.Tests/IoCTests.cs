﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectIt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectIt.Tests
{
    [TestClass()]
    public class IoCTests
    {
        [TestMethod()]
        public void Can_Resolve_Types()
        {
            var ioc = new Container();
            ioc.For<ILogger>().Use<SqlServerLogger>();
            var logger = ioc.Resolve<ILogger>();
            Assert.AreEqual(typeof(SqlServerLogger), logger.GetType());
        }
        [TestMethod()]
        public void Can_Resolve_Types_Without_Default_Ctor()
        {
            var ioc = new Container();
            ioc.For<ILogger>().Use<SqlServerLogger>();
            ioc.For<IRepository<Employee>>().Use<SqlRepository<Employee>>();
            var repository = ioc.Resolve<IRepository<Employee>>();
            Assert.AreEqual(typeof(SqlRepository<Employee>), repository.GetType());
        }
        [TestMethod()]
        public void Can_Resolve_Types_With_Concrete_Type()
        {
            var ioc = new Container();
            ioc.For<ILogger>().Use<SqlServerLogger>();
            ioc.For(typeof(IRepository <>)).Use(typeof(SqlRepository<>));
            var service = ioc.Resolve<InvoiceService>();
            Assert.IsNotNull(service);
            //Assert.AreEqual(typeof(InvoiceService), repository.GetType());
        }
    }
}