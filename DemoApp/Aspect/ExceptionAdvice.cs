//
// ExceptionAdvice.cs
//
// Created by Sehwan Noh on 4/25/2013.
//

using Common.Logging;
using Spring.Aop;
using System;

namespace DemoApp.Aspect
{
    public class ExceptionAdvice : IThrowsAdvice
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ExceptionAdvice));

        public ExceptionAdvice()
        {
        }

        public void AfterThrowing(Exception ex)
        {
            log.Error("----------------------error----------------------");
            log.Error(ex);
        }
    }
}
