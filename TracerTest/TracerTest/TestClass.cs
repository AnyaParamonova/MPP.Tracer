﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPPTracer;
using MPPTracer.Format;

namespace TracerTest
{
    class TestClass
    {
        static Tracer tracer = new Tracer();
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            test.method1();
            TraceResult result = tracer.GetTraceResult();
            ConsoleFormatter formatter = new ConsoleFormatter();
            String formatResult = formatter.Format(result);
            Console.WriteLine(formatResult);
            Console.ReadLine();

        }

        private void longMethod()
        {
            System.Threading.Thread.Sleep(1000);
        }

        private void method1()
        {
            tracer.StartTrace();
                longMethod();
                method2();
            tracer.StopTrace();
        }
        private void method2()
        {
            tracer.StartTrace();
                longMethod();
            tracer.StopTrace();
        }
        private void method3()
        {

        }

    }
}