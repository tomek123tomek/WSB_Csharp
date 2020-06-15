using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatyItp {

    class ExampleTransformer {

        public delegate int Transformer(int x);
        public event Action TransformationCompleted;

        public void Transform(Transformer t, int value) {
            int ret = t(value);
            //Console.WriteLine($"Output value is: {ret}");
            TransformationCompleted.Invoke();
        }

        public void Transform(Func<int, int, int> t, int value1, int value2){
            try {
                int ret = t(value1, value2);
                //Console.WriteLine($"Output value is: {ret}");
                TransformationCompleted.Invoke();
            }
            catch (DivideByZeroException) {
                Console.WriteLine("pamietaj cholera zeby nie dzielic przez 0");
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("FINALLY");
            }
        }
    }


}