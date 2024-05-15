using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "Calculadora" en el código, en svc y en el archivo de configuración a la vez.
public class Calculadora : ICalculadora
{
    public double Divide(double num1, double num2)
    {
        if(num2 == 0)
        {
            throw new DivideByZeroException("No es posible la división entre cero");
        }

        return num1 / num2;
    }

    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Sum(double num1, double num2)
    {
        return num1 + num2;
    }
}
