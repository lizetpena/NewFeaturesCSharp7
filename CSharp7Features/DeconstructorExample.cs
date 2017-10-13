using System;

namespace CSharp7Features
{
    public class DeconstructorExample
    {
        public void Examples()
        {
            PathInfo pathInfo = new PathInfo(@"\\test\unc\path\to\something.ext");
            {
                // Example 1: Deconstructing declaration and assignment.
                (string directoryName, string fileName, string extension) = pathInfo;
                VerifyExpectedValue(directoryName, fileName, extension);
            }
            {
                //notice simultaneous asignment to multiple variables, all variables are initialized with null
                string directoryName, fileName, extension = null;
                
                // Example 2: Deconstructing assignment.
                (directoryName, fileName, extension) = pathInfo;
                VerifyExpectedValue(directoryName, fileName, extension);
            }
            {
                // Example 3: Deconstructing declaration and assignment with var.
                var (directoryName, fileName, extension) = pathInfo;
                VerifyExpectedValue(directoryName, fileName, extension);
            }
        }

        private void VerifyExpectedValue(string directoryName, string fileName, string extension)
        {
           
            throw new NotImplementedException();
        }
    }

}
