using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignLanguageRecognition
{
    class Char2SvmClass
    {
        public static int char2class(char c){
            int svmClass = 0;
            switch (c)
            {
                case 'א':
                    svmClass = 1;
                    break;
                case 'ב':
                    svmClass = 2;
                    break;
                case 'ח':
                    svmClass = 3;
                    break;
                case 'ל':
                    svmClass = 4;
                    break;
                case 'י':
                    svmClass = 5;
                    break;
                case 'ו':
                    svmClass = 6;
                    break;


            }
            return svmClass;
        }
        public static char class2svm(int decision)
        {
            char c='*';
            switch (decision)
            {
                
                case (1):
                    c = 'א';
                    break;
                case (2):
                    c = 'ב';
                    break;
                case (3):
                    c = 'ח';
                    break;
                case (4):
                    c = 'ל';
                    break;
                case (5):
                    c = 'י';
                    break;
                case (0):
                    c = 'ו';
                    break;

            }
            return c;
        }

    }
}
