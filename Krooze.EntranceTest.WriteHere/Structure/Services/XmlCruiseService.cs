using Krooze.EntranceTest.WriteHere.Structure.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;

namespace Krooze.EntranceTest.WriteHere.Structure.Services
{
    public class XmlCruiseService
    {        
        private const string _XMLPATH = @"D:\Estudos\C#\kroozegdschallenge-master\kroozegdschallenge-master\Krooze.EntranceTest.WriteHere\Resources\Cruises.xml";        
        XmlNode nodeRoot = null;
        XmlDocument xmlDocument = null;
        XmlNodeList listPax = null;
        string XmlString = string.Empty;
        private IConfiguration _configuration = null;

        public XmlCruiseService()
        {
            xmlDocument = new XmlDocument();                        
        }        

        public CruiseDTO GetCruiseXml()
        {
            LoadAndSetXml();
            CruiseDTO cruiseDTO = ReturnCruiseValues();
            cruiseDTO.PassengerCruise = ReturnPassengerCruiseList();
            return cruiseDTO;
        }

        private void LoadAndSetXml()
        {            
            xmlDocument.LoadXml(File.ReadAllText(_XMLPATH));
            SetXmlNodesList();
        }       

        private void SetXmlNodesList()
        {
            nodeRoot = xmlDocument.SelectSingleNode("Cruises");
            listPax = nodeRoot.SelectNodes("CategoryPriceDetails/Pax");
        }

        private List<PassengerCruiseDTO> ReturnPassengerCruiseList()
        {
            List<PassengerCruiseDTO> passengerCruiseList = new List<PassengerCruiseDTO>();
            foreach (XmlNode node in listPax)
            {
                PassengerCruiseDTO passengerCruiseDTO = new PassengerCruiseDTO();
                passengerCruiseDTO.PassengerCode = node.Attributes.GetNamedItem("PaxID").InnerText;
                passengerCruiseDTO.Cruise = new CruiseDTO();
                passengerCruiseDTO.Cruise.TotalValue = GetDecimalNodeValue("AllInclusivePerPax", node);
                foreach (XmlNode nodeCharge in node.SelectNodes("Charge"))
                {
                    if (nodeCharge.Attributes.GetNamedItem("ChargeType").InnerText == "CAB")
                        passengerCruiseDTO.Cruise.CabinValue = GetDecimalNodeValue("GrossAmountBfrDisc", nodeCharge);

                    if (nodeCharge.Attributes.GetNamedItem("ChargeType").InnerText == "PCH")
                        passengerCruiseDTO.Cruise.PortCharge = GetDecimalNodeValue("GrossAmountBfrDisc", nodeCharge);
                }
                passengerCruiseList.Add(passengerCruiseDTO);
            }
            return passengerCruiseList;
        }

        private CruiseDTO ReturnCruiseValues()
        {
            CruiseDTO cruiseValues = new CruiseDTO();
            cruiseValues.CruiseCode = GetStringNodeValue("CruiseId");
            cruiseValues.ShipName = GetStringNodeValue("ShipName");
            cruiseValues.CabinValue = GetDecimalNodeValue("CabinPrice", nodeRoot);
            cruiseValues.PortCharge = GetDecimalNodeValue("PortChargesAmt", nodeRoot);
            cruiseValues.TotalValue = GetDecimalNodeValue("TotalCabinPrice", nodeRoot);

            return cruiseValues;
        }

        private decimal GetDecimalNodeValue(string nodeName, XmlNode node)
        {
            return Convert.ToDecimal(node.SelectSingleNode(nodeName).InnerText, CultureInfo.GetCultureInfo("en-US"));
        }

        private string GetStringNodeValue(string nodeName)
        {
            return nodeRoot.SelectSingleNode(nodeName).InnerText;
        }

    }
}
