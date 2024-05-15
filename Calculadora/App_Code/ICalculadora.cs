using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICalculadora" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ICalculadora
{
    [OperationContract]
    double Sum(double num1, double num2);
    [OperationContract]
    double Subtract(double num1, double num2);
    [OperationContract]
    double Multiply(double num1, double num2);
    [OperationContract]
    double Divide(double num1, double num2);
}
