using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GRA.Models
{
    public class TundukPinResponseModel
    {
        [XmlRoot(ElementName = "client", Namespace = "http://x-road.eu/xsd/xroad.xsd")]
        public class Client
        {
            [XmlElement(ElementName = "xRoadInstance", Namespace = "http://x-road.eu/xsd/identifiers")]
            public string XRoadInstance { get; set; }
            [XmlElement(ElementName = "memberClass", Namespace = "http://x-road.eu/xsd/identifiers")]
            public string MemberClass { get; set; }
            [XmlElement(ElementName = "memberCode", Namespace = "http://x-road.eu/xsd/identifiers")]
            public string MemberCode { get; set; }
            [XmlElement(ElementName = "subsystemCode", Namespace = "http://x-road.eu/xsd/identifiers")]
            public string SubsystemCode { get; set; }
            [XmlAttribute(AttributeName = "objectType", Namespace = "http://x-road.eu/xsd/identifiers")]
            public string ObjectType { get; set; }
        }

        [XmlRoot(ElementName = "service", Namespace = "http://x-road.eu/xsd/xroad.xsd")]
        public class Service
        {
            [XmlElement(ElementName = "xRoadInstance", Namespace = "http://x-road.eu/xsd/identifiers")]
            public string XRoadInstance { get; set; }
            [XmlElement(ElementName = "memberClass", Namespace = "http://x-road.eu/xsd/identifiers")]
            public string MemberClass { get; set; }
            [XmlElement(ElementName = "memberCode", Namespace = "http://x-road.eu/xsd/identifiers")]
            public string MemberCode { get; set; }
            [XmlElement(ElementName = "subsystemCode", Namespace = "http://x-road.eu/xsd/identifiers")]
            public string SubsystemCode { get; set; }
            [XmlElement(ElementName = "serviceCode", Namespace = "http://x-road.eu/xsd/identifiers")]
            public string ServiceCode { get; set; }
            [XmlElement(ElementName = "serviceVersion", Namespace = "http://x-road.eu/xsd/identifiers")]
            public string ServiceVersion { get; set; }
            [XmlAttribute(AttributeName = "objectType", Namespace = "http://x-road.eu/xsd/identifiers")]
            public string ObjectType { get; set; }
        }

        [XmlRoot(ElementName = "requestHash", Namespace = "http://x-road.eu/xsd/xroad.xsd")]
        public class RequestHash
        {
            [XmlAttribute(AttributeName = "algorithmId")]
            public string AlgorithmId { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class Header
        {
            [XmlElement(ElementName = "client", Namespace = "http://x-road.eu/xsd/xroad.xsd")]
            public Client Client { get; set; }
            [XmlElement(ElementName = "service", Namespace = "http://x-road.eu/xsd/xroad.xsd")]
            public Service Service { get; set; }
            [XmlElement(ElementName = "userId", Namespace = "http://x-road.eu/xsd/xroad.xsd")]
            public string UserId { get; set; }
            [XmlElement(ElementName = "id", Namespace = "http://x-road.eu/xsd/xroad.xsd")]
            public string Id { get; set; }
            [XmlElement(ElementName = "requestHash", Namespace = "http://x-road.eu/xsd/xroad.xsd")]
            public RequestHash RequestHash { get; set; }
            [XmlElement(ElementName = "issue", Namespace = "http://x-road.eu/xsd/xroad.xsd")]
            public string Issue { get; set; }
            [XmlElement(ElementName = "protocolVersion", Namespace = "http://x-road.eu/xsd/xroad.xsd")]
            public string ProtocolVersion { get; set; }
        }

        [XmlRoot(ElementName = "request", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class Request
        {
            [XmlElement(ElementName = "pin", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Pin { get; set; }
            [XmlElement(ElementName = "datetimeFormat", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string DatetimeFormat { get; set; }
        }

        [XmlRoot(ElementName = "request", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class PassportRequest
        {
            [XmlElement(ElementName = "pin", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Pin { get; set; }
            [XmlElement(ElementName = "series", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Series { get; set; }
            [XmlElement(ElementName = "number", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Number { get; set; }
        }

        [XmlRoot(ElementName = "response", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class PersonByPinTundukDTO
        {
            [XmlElement(ElementName = "pin", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Pin { get; set; }
            [XmlElement(ElementName = "name", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Name { get; set; }
            [XmlElement(ElementName = "surname", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Surname { get; set; }
            [XmlElement(ElementName = "patronymic", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Patronymic { get; set; }
            [XmlElement(ElementName = "gender", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Gender { get; set; }
            [XmlElement(ElementName = "maritalStatus", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string MaritalStatus { get; set; }
            [XmlElement(ElementName = "maritalStatusId", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string MaritalStatusId { get; set; }
            [XmlElement(ElementName = "nationality", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Nationality { get; set; }
            [XmlElement(ElementName = "nationalityId", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string NationalityId { get; set; }
            [XmlElement(ElementName = "citizenship", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string CitizenShip { get; set; }
            [XmlElement(ElementName = "citizenshipId", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string CitizenshipId { get; set; }
            [XmlElement(ElementName = "pinBlocked", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public bool PinBlocked { get; set; }
            [XmlElement(ElementName = "pinGenerationDate", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string PinGenerationDate { get; set; }
            [XmlElement(ElementName = "dateOfBirth", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string DateOfBirth { get; set; }
            [XmlElement(ElementName = "deathDate", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string DeathDate { get; set; }
        }

        [XmlRoot(ElementName = "response", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class PersonPhotoByPinTundukDTO
        {
            [XmlElement(ElementName = "photo", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Photo { get; set; }
            [XmlElement(ElementName = "error", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public bool Error { get; set; }
            [XmlElement(ElementName = "errorMessage", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string ErrorMessage { get; set; }
        }

        [XmlRoot(ElementName = "addressArray", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class PersonAddressArray
        {
            [XmlElement(ElementName = "countryId", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string countryId { get; set; }
            [XmlElement(ElementName = "regionId", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string regionId { get; set; }
            [XmlElement(ElementName = "districtId", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string districtId { get; set; }
            [XmlElement(ElementName = "aymakId", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string aymakId { get; set; }
            [XmlElement(ElementName = "villageId", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string villageId { get; set; }
            [XmlElement(ElementName = "streetId", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string streetId { get; set; }
            [XmlElement(ElementName = "houseId", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string houseId { get; set; }
            [XmlElement(ElementName = "houseTxt", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string houseTxt { get; set; }
            [XmlElement(ElementName = "flatId", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string flatId { get; set; }
            [XmlElement(ElementName = "flatTxt", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string flatTxt { get; set; }
            [XmlElement(ElementName = "code", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string code { get; set; }
            [XmlElement(ElementName = "post", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string post { get; set; }

        }

        [XmlRoot(ElementName = "cars", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class Cars
        {
            [XmlElement(ElementName = "govPlate", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string GovPlate { get; set; }
            [XmlElement(ElementName = "carTypeName", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string CarTypeName { get; set; }
            [XmlElement(ElementName = "bodyType", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string BodyType { get; set; }
            [XmlElement(ElementName = "brand", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Brand { get; set; }
            [XmlElement(ElementName = "model", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Model { get; set; }
            [XmlElement(ElementName = "steering", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Steering { get; set; }
            [XmlElement(ElementName = "year", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Year { get; set; }
            [XmlElement(ElementName = "color", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Color { get; set; }
            [XmlElement(ElementName = "bodyNo", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string BodyNo { get; set; }
            [XmlElement(ElementName = "vin", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Vin { get; set; }
            [XmlElement(ElementName = "engineVolume", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string EngineVolume { get; set; }
        }

        [XmlRoot(ElementName = "response", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class CarResponse
        {
            [XmlElement(ElementName = "status", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Status { get; set; }
            [XmlElement(ElementName = "cars", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public List<Cars> Cars { get; set; }
        }

        [XmlRoot(ElementName = "response", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class PersonAddressByPinTundukDTO
        {
            [XmlElement(ElementName = "error", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public bool Error { get; set; }
            [XmlElement(ElementName = "address", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Address { get; set; }
            [XmlElement(ElementName = "dateAction", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string DateAction { get; set; }
            [XmlElement(ElementName = "dateCreated", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string DateCreated { get; set; }
            [XmlElement(ElementName = "addressArray", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public PersonAddressArray personAddressArray { get; set; }
        }

        [XmlRoot(ElementName = "response", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class PassportDataByPSNTundukDTO
        {
            [XmlElement(ElementName = "faultcode", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Faultcode { get; set; }
            [XmlElement(ElementName = "faultstring", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Faultstring { get; set; }
            [XmlElement(ElementName = "pin", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Pin { get; set; }
            [XmlElement(ElementName = "surname", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Surname { get; set; }
            [XmlElement(ElementName = "name", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Name { get; set; }
            [XmlElement(ElementName = "patronymic", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Patronymic { get; set; }
            [XmlElement(ElementName = "nationality", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Nationality { get; set; }
            [XmlElement(ElementName = "dateOfBirth", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string DateOfBirth { get; set; }
            [XmlElement(ElementName = "passportSeries", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string PassportSeries { get; set; }
            [XmlElement(ElementName = "passportNumber", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string PassportNumber { get; set; }
            [XmlElement(ElementName = "voidStatus", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string VoidStatus { get; set; }
            [XmlElement(ElementName = "passportAuthority", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string passportAuthority { get; set; }
            [XmlElement(ElementName = "issuedDate", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string IssuedDate { get; set; }
            [XmlElement(ElementName = "expiredDate", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string ExpiredDate { get; set; }
            [XmlElement(ElementName = "voidMotiv", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string VoidMotiv { get; set; }
            [XmlElement(ElementName = "familyStatus", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string FamilyStatus { get; set; }
            [XmlElement(ElementName = "gender", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string Gender { get; set; }
            [XmlElement(ElementName = "addressRegion", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string AddressRegion { get; set; }
            [XmlElement(ElementName = "addressLocality", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string AddressLocality { get; set; }
            [XmlElement(ElementName = "addressStreet", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string AddressStreet { get; set; }
            [XmlElement(ElementName = "addressHouse", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string AddressHouse { get; set; }
            [XmlElement(ElementName = "addressBuilding", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string AddressBuilding { get; set; }
            [XmlElement(ElementName = "addressApartment", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public string AddressApartment { get; set; }
        }

        [XmlRoot(ElementName = "zagsDataByPinResponse", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class ZagsDataByPinResponse
        {
            [XmlElement(ElementName = "request", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public Request Request { get; set; }
            [XmlElement(ElementName = "response", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public PersonByPinTundukDTO personByPinTundukDTO { get; set; }
            [XmlAttribute(AttributeName = "ts1", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Ts1 { get; set; }
        }

        [XmlRoot(ElementName = "passportLastPhotoByPinResponse", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class PassportLastPhotoByPinResponse
        {
            [XmlElement(ElementName = "request", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public Request Request { get; set; }
            [XmlElement(ElementName = "response", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public PersonPhotoByPinTundukDTO personPhotoByPinTundukDTO { get; set; }
            [XmlAttribute(AttributeName = "ts1", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Ts1 { get; set; }
        }

        [XmlRoot(ElementName = "asbAddressResponse", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class AsbAddressResponse
        {
            [XmlElement(ElementName = "request", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public Request Request { get; set; }
            [XmlElement(ElementName = "response", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public PersonAddressByPinTundukDTO personAddressByPinTundukDTO { get; set; }
            [XmlAttribute(AttributeName = "ts1", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Ts1 { get; set; }
        }

        [XmlRoot(ElementName = "passportDataByPSNResponse", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class PassportDataByPSNResponse
        {
            [XmlElement(ElementName = "request", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public PassportRequest Request { get; set; }
            [XmlElement(ElementName = "response", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public PassportDataByPSNTundukDTO passportDataByPSNTundukDTO { get; set; }
            [XmlAttribute(AttributeName = "ts1", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Ts1 { get; set; }
        }

        [XmlRoot(ElementName = "transportByPinResponse", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
        public class TransportByPinResponse
        {
            [XmlElement(ElementName = "request", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public Request Request { get; set; }
            [XmlElement(ElementName = "response", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public CarResponse Response { get; set; }
            [XmlAttribute(AttributeName = "ts1", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Ts1 { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class PinBody
        {
            [XmlElement(ElementName = "zagsDataByPinResponse", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public ZagsDataByPinResponse zagsDataByPinResponse { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class PhotoBody
        {
            [XmlElement(ElementName = "passportLastPhotoByPinResponse", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public PassportLastPhotoByPinResponse passportLastPhotoByPinResponse { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class AddressBody
        {
            [XmlElement(ElementName = "asbAddressResponse", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public AsbAddressResponse asbAddressResponse { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class PassportBody
        {
            [XmlElement(ElementName = "passportDataByPSNResponse", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public PassportDataByPSNResponse passportDataByPSNResponse { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class CarBody
        {
            [XmlElement(ElementName = "transportByPinResponse", Namespace = "http://tunduk-seccurity-infocom.x-road.fi/producer")]
            public TransportByPinResponse TransportByPinResponse { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class PinEnvelope
        {
            [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
            public Header Header { get; set; }
            [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
            public PinBody Body { get; set; }
            [XmlAttribute(AttributeName = "SOAP-ENV", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string SOAPENV { get; set; }
            [XmlAttribute(AttributeName = "id", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Id { get; set; }
            [XmlAttribute(AttributeName = "xrd", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xrd { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class PhotoEnvelope
        {
            [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
            public Header Header { get; set; }
            [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
            public PhotoBody Body { get; set; }
            [XmlAttribute(AttributeName = "SOAP-ENV", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string SOAPENV { get; set; }
            [XmlAttribute(AttributeName = "id", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Id { get; set; }
            [XmlAttribute(AttributeName = "xrd", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xrd { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class AddressEnvelope
        {
            [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
            public Header Header { get; set; }
            [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
            public AddressBody Body { get; set; }
            [XmlAttribute(AttributeName = "SOAP-ENV", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string SOAPENV { get; set; }
            [XmlAttribute(AttributeName = "id", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Id { get; set; }
            [XmlAttribute(AttributeName = "xrd", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xrd { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class PassportEnvelope
        {
            [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
            public Header Header { get; set; }
            [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
            public PassportBody Body { get; set; }
            [XmlAttribute(AttributeName = "SOAP-ENV", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string SOAPENV { get; set; }
            [XmlAttribute(AttributeName = "id", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Id { get; set; }
            [XmlAttribute(AttributeName = "xrd", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xrd { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class CarEnvelope
        {
            [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
            public Header Header { get; set; }
            [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
            public CarBody Body { get; set; }
            [XmlAttribute(AttributeName = "SOAP-ENV", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string SOAPENV { get; set; }
            [XmlAttribute(AttributeName = "id", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Id { get; set; }
            [XmlAttribute(AttributeName = "xrd", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xrd { get; set; }
        }
    }
}
