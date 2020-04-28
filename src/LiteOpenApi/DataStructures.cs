using System.Collections.Generic;
using LiteOpenApi;

public class OpenApiDoc
{
    public string Openapi { get; set; }
    public OpenApiInfo Info { get; set; }
    public List<Server> Servers { get; set; }
    public Dictionary<string, object> Paths { get; set; }
    public OpenApiDocComponents Components { get; set; }
    public List<Security> Security { get; set; }
}

public class GetPath
{
    public PathDetails Get { get; set; }
}

public class PostPath
{
    public PathDetails Post { get; set; }
}

public class PathDetails
{
    public List<string> Tags { get; set; } = new List<string>();
    public Dictionary<string, ResponseDetail> Responses { get; set; } = new Dictionary<string, ResponseDetail>();
}

public class ResponseDetail
{
    public string? Description { get; set; }
    public Dictionary<string, ResponseContentDetail> Content { get; set; }
}

public class ResponseContentDetail
{
}



public class OpenApiInfo
{
    public string Title { get; set; } = "Untitled API";
    public string? Description { get; set; }
    public string? TermsOfService { get; set; }
    public Contact? Contact { get; set; }
    public License? License { get; set; }
    public string Version { get; set; } = "1";
}

public class License
{
    public string Name { get; set; }
    public string? Url { get; set; }
}

public class Contact
{
    public string Name { get; set; }
    public string? Url { get; set; }
    public string? Email { get; set; }
}

public class Server
{
    public string Url { get; set; }
}

namespace LiteOpenApi
{
    public class OpenApiDocComponents
    {
        public Schemas Schemas { get; set; }
        public SecuritySchemes SecuritySchemes { get; set; }
    }

    public class Schemas
    {
        public AppStatus AppStatus { get; set; }
        public AppHealthDetailsResponse AppHealthDetailsResponse { get; set; }
        public ReasonDetailClass ReasonDetail { get; set; }
        public ReasonCategory ReasonCategory { get; set; }
        public ReturnReasonsListResponse ReturnReasonsListResponse { get; set; }
        public ResultStatus ResultStatus { get; set; }
        public ReturnReasonsListResponseResult ReturnReasonsListResponseResult { get; set; }
        public ReasonDetail ReturnReasonDetail { get; set; }
        public AddReturnReasonsRequest AddReturnReasonsRequest { get; set; }
        public Result Result { get; set; }
        public ReasonDetail GetReasonDetail { get; set; }
        public VehicleReturnReasons VehicleReturnReasons { get; set; }
        public VehicleReturnReasonsResponse VehicleReturnReasonsResponse { get; set; }
    }

    public class AddReturnReasonsRequest
    {
        public string Type { get; set; }
        public AddReturnReasonsRequestProperties Properties { get; set; }
    }

    public class AddReturnReasonsRequestProperties
    {
        public ReferenceId VehicleId { get; set; }
        public ReferenceId SubmitterEmail { get; set; }
        public ReferenceId ReferenceId { get; set; }
        public ReferenceId ReferenceIdType { get; set; }
        public Reasons Reasons { get; set; }
    }

    public class Reasons
    {
        public string Type { get; set; }
        public Status Items { get; set; }
        public bool Nullable { get; set; }
    }

    public class Status
    {
        public string Ref { get; set; }
    }

    public class ReferenceId
    {
        public TypeEnum Type { get; set; }
        public bool Nullable { get; set; }
    }

    public class AppHealthDetailsResponse
    {
        public string Type { get; set; }
        public AppHealthDetailsResponseProperties Properties { get; set; }
    }

    public class AppHealthDetailsResponseProperties
    {
        public ReferenceId OverallHealth { get; set; }
        public PropertiesComponents Components { get; set; }
    }

    public class PropertiesComponents
    {
        public string Type { get; set; }
        public AdditionalProperties AdditionalProperties { get; set; }
        public bool Nullable { get; set; }
    }

    public class AdditionalProperties
    {
        public TypeEnum Type { get; set; }
    }

    public class AppStatus
    {
        public string Type { get; set; }
        public AppStatusProperties Properties { get; set; }
    }

    public class AppStatusProperties
    {
        public ReferenceId Message { get; set; }
        public ReferenceId Version { get; set; }
        public StatusDateTime StatusDateTime { get; set; }
    }

    public class StatusDateTime
    {
        public TypeEnum Type { get; set; }
        public string Format { get; set; }
    }

    public class ReasonDetail
    {
        public string Type { get; set; }
        public GetReasonDetailProperties Properties { get; set; }
    }

    public class GetReasonDetailProperties
    {
        public ReferenceId ReasonDetailId { get; set; }
        public ReferenceId Category { get; set; }
        public ReferenceId Reason { get; set; }
        public ReferenceId Detail { get; set; }
        public ReferenceId Note { get; set; }
    }

    public class ReasonCategory
    {
        public string Type { get; set; }
        public ReasonCategoryProperties Properties { get; set; }
    }

    public class ReasonCategoryProperties
    {
        public ReferenceId Category { get; set; }
        public Reasons Reasons { get; set; }
    }

    public class ReasonDetailClass
    {
        public string Type { get; set; }
        public ReasonDetailProperties Properties { get; set; }
    }

    public class ReasonDetailProperties
    {
        public ReferenceId Reason { get; set; }
        public Details Details { get; set; }
    }

    public class Details
    {
        public string Type { get; set; }
        public AdditionalProperties Items { get; set; }
        public bool Nullable { get; set; }
    }

    public class Result
    {
        public string Type { get; set; }
        public ResultProperties Properties { get; set; }
    }

    public class ResultProperties
    {
        public Status Status { get; set; }
        public ErrorMessage ErrorMessage { get; set; }
    }

    public class ErrorMessage
    {
        public TypeEnum Type { get; set; }
        public bool Nullable { get; set; }
        public bool ReadOnly { get; set; }
    }

    public class ResultStatus
    {
        public List<long> Enum { get; set; }
        public string Type { get; set; }
        public string Format { get; set; }
    }

    public class ReturnReasonsListResponse
    {
        public string Type { get; set; }
        public ReturnReasonsListResponseProperties Properties { get; set; }
    }

    public class ReturnReasonsListResponseProperties
    {
        public Reasons ReasonCategories { get; set; }
    }

    public class ReturnReasonsListResponseResult
    {
        public string Type { get; set; }
        public ReturnReasonsListResponseResultProperties Properties { get; set; }
    }

    public class ReturnReasonsListResponseResultProperties
    {
        public Status Content { get; set; }
        public Status Status { get; set; }
        public ErrorMessage ErrorMessage { get; set; }
    }

    public class VehicleReturnReasons
    {
        public string Type { get; set; }
        public VehicleReturnReasonsProperties Properties { get; set; }
    }

    public class VehicleReturnReasonsProperties
    {
        public ReferenceId ReasonId { get; set; }
        public ReferenceId VehicleId { get; set; }
        public ReferenceId StockNumber { get; set; }
        public ReferenceId Vin { get; set; }
        public ReferenceId SubmitterEmail { get; set; }
        public ReferenceId ReferenceId { get; set; }
        public ReferenceId ReferenceIdType { get; set; }
        public Reasons Reasons { get; set; }
    }

    public class VehicleReturnReasonsResponse
    {
        public string Type { get; set; }
        public VehicleReturnReasonsResponseProperties Properties { get; set; }
    }

    public class VehicleReturnReasonsResponseProperties
    {
        public Reasons ReturnReasons { get; set; }
    }

    public class SecuritySchemes
    {
        public Bearer Bearer { get; set; }
    }

    public class Bearer
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string Scheme { get; set; }
    }





    public class Paths
    {
        public ApiV1Status ApiV1Status { get; set; }
        public ApiV1StatusLog ApiV1StatusLog { get; set; }
        public ApiV1Status ApiV1StatusAuthorized { get; set; }
        public ApiV1Status ApiV1StatusHealth { get; set; }

        public ApiV1VehiclereturnreasonsAllvalidreasonselections ApiV1VehiclereturnreasonsAllvalidreasonselections
        {
            get;
            set;
        }

        public ApiV1Vehiclereturnreasons ApiV1Vehiclereturnreasons { get; set; }

        public ApiV1VehiclereturnreasonsStocknumberStocknumberClass ApiV1VehiclereturnreasonsVehicleidVehicleid
        {
            get;
            set;
        }

        public ApiV1VehiclereturnreasonsStocknumberStocknumberClass ApiV1VehiclereturnreasonsVinVin { get; set; }

        public ApiV1VehiclereturnreasonsStocknumberStocknumberClass ApiV1VehiclereturnreasonsStocknumberStocknumber
        {
            get;
            set;
        }
    }

    public class ApiV1Status
    {
        public ApiV1StatusGet Get { get; set; }
    }

    public class ApiV1StatusGet
    {
        public List<string> Tags { get; set; }
        public GetResponses Responses { get; set; }
    }

    public class GetResponses
    {
        public Purple200 The200 { get; set; }
    }

    public class Purple200
    {
        public Description Description { get; set; }
        public The200_Content Content { get; set; }
    }

    public class The200_Content
    {
        public Json ApplicationJson { get; set; }
    }

    public class Json
    {
        public Status Schema { get; set; }
        public string Example { get; set; }
    }

    public class ApiV1StatusLog
    {
        public ApiV1StatusLogPost Post { get; set; }
    }

    public class ApiV1StatusLogPost
    {
        public List<string> Tags { get; set; }
        public PostResponses Responses { get; set; }
    }

    public class PostResponses
    {
        public Fluffy200 The200 { get; set; }
    }

    public class Fluffy200
    {
        public Description Description { get; set; }
    }

    public class ApiV1Vehiclereturnreasons
    {
        public ApiV1VehiclereturnreasonsPost Post { get; set; }
    }

    public class ApiV1VehiclereturnreasonsPost
    {
        public List<string> Tags { get; set; }
        public RequestBody RequestBody { get; set; }
        public Dictionary<string, PostResponse> Responses { get; set; }
    }

    public class RequestBody
    {
        public RequestBodyContent Content { get; set; }
    }

    public class RequestBodyContent
    {
        public Json ApplicationJsonPatchJson { get; set; }
        public Json ContentApplicationJson { get; set; }
        public Json TextJson { get; set; }
        public Json ApplicationJson { get; set; }
    }

    public class PostResponse
    {
        public Description Description { get; set; }
        public PurpleContent Content { get; set; }
    }

    public class PurpleContent
    {
        public ApplicationJson ApplicationJson { get; set; }
    }

    public class ApplicationJson
    {
        public Status Schema { get; set; }
    }

    public class ApiV1VehiclereturnreasonsAllvalidreasonselections
    {
        public ApiV1VehiclereturnreasonsAllvalidreasonselectionsGet Get { get; set; }
    }

    public class ApiV1VehiclereturnreasonsAllvalidreasonselectionsGet
    {
        public List<string> Tags { get; set; }
        public Dictionary<string, GetResponse> Responses { get; set; }
    }

    public class GetResponse
    {
        public Description Description { get; set; }
        public The200_Content Content { get; set; }
    }

    public class ApiV1VehiclereturnreasonsStocknumberStocknumberClass
    {
        public ApiV1VehiclereturnreasonsStocknumberStocknumberGet Get { get; set; }
    }

    public class ApiV1VehiclereturnreasonsStocknumberStocknumberGet
    {
        public List<string> Tags { get; set; }
        public List<Parameter> Parameters { get; set; }
        public Dictionary<string, GetResponse> Responses { get; set; }
    }

    public class Parameter
    {
        public string Name { get; set; }
        public string In { get; set; }
        public bool ParameterRequired { get; set; }
        public ReferenceId Schema { get; set; }
    }

    public class Security
    {
        public List<object> Bearer { get; set; }
    }


    public enum TypeEnum
    {
        String
    };

    public enum Description
    {
        BadRequest,
        NotFound,
        ServerError,
        Success
    };
}
