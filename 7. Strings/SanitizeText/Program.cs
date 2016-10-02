using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanitizeText
{
    class Program
    {
        static void Main()
        {
            // < &#60;

            // > &#62;

            var html = @"<!DOCTYPE html>
<html>
  <head>
    <meta charset=""utf - 8"">
      < title ></ title >
    </ head >
    < body >
    {0}
  </ body >
</ html > ";

            var badUsername = "<script>alert('hello gosho');</script>";
            var sanitazed = badUsername
                                .Replace("<", "&#60;")
                                .Replace(">", "&#62;");
            Console.WriteLine(html,sanitazed);
        }
    }
}
