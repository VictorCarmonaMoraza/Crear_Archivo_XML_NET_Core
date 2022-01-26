using System;
using System.Xml;

namespace CrearArchivoXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriter ejemploXml = XmlWriter.Create("PruebaXML.xml");
            //Iniciamos el documento
            ejemploXml.WriteStartDocument();

            ejemploXml.WriteStartElement("Libros");
            ejemploXml.WriteStartElement("Libro");
            ejemploXml.WriteAttributeString("Autor","Sofia Cristo");
            //Nodos Hijos
            ejemploXml.WriteStartElement("Titulo");
            ejemploXml.WriteString("La Historia interminable");
            ejemploXml.WriteEndElement();

            ejemploXml.WriteStartElement("Paginas");
            ejemploXml.WriteString("2500");
            ejemploXml.WriteEndElement();

            //Cerramos el nodo Libro
            ejemploXml.WriteEndElement(); //------------

            ejemploXml.WriteStartElement("Libro");
            ejemploXml.WriteAttributeString("Autor", "Sofia Cristo");
            //Nodos Hijos
            ejemploXml.WriteStartElement("Titulo");
            ejemploXml.WriteString("La Historia interminable");
            ejemploXml.WriteEndElement();

            ejemploXml.WriteStartElement("Paginas");
            ejemploXml.WriteString("2500");
            ejemploXml.WriteEndElement();

            //Cerramos el nodo Libro
            ejemploXml.WriteEndElement(); //------------

            //Finalizar el documento
            ejemploXml.WriteEndDocument();
            //Finalizamos siempre su escritura
            ejemploXml.Close();
        }
    }
}
