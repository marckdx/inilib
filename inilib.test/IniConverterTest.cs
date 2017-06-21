﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using inilib.test.Model;

namespace inilib.test
{
    [TestClass]
    public class IniConverterTest
    {
        [TestMethod]
        public void TestDeserializeToInifile()
        {
            String path = @"D:\Repositorios\inilib\testobjs\Test1.ini";
            IniFile inifile = IniConverter.DeserializeToInifile(path);

            String value = inifile.SearchSection("test").SearchKeys("name").Value;
            Assert.AreEqual(value, "none");
        }

        [TestMethod]
        public void TestSerializeObject()
        {
           Person p = new Person("Hawke", 18);
           String[] ini = IniConverter.SerializeObject(p);
           Assert.AreEqual(ini[0], String.Format("[{0}]", "Person"));
        }
    }
}
