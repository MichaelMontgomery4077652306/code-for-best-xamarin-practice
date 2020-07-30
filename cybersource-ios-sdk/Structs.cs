using System.Runtime.InteropServices;

namespace InAppSDK
{
    public enum InappsdkEnvironment : uint
    {
        Live,
        Test
    }

    public enum InAppSDKGatewayApiType : uint
    {
        Init = 0,
        Encrypt
    }

    public enum InAppSDKTransactionType : uint
    {
        Undefined = 0,
        Encrypt
    }

    public enum InAppSDKGatewayResponseDecisionType : uint
    {
        Unknown = 0,
        Accept,
        Error,
        Reject,
        Review,
        Failed
    }

    public enum InAppSDKErrorType : uint
    {
        InappsdkErrorTypeUnknown = 0
    }

    public enum InAppSDKGatewayErrorType : uint
    {
        TypeUnknown = 2000,
        MissingFields,
        FieldsContainsInvalidData,
        OnlyPartialApproved,
        GeneralSystemFailure,
        ServerTimeout,
        ServiceDidNotFinish,
        DidNotPassAvs,
        IssuingBankHasQuestions,
        ExpiredCard,
        GeneralDecline,
        InsufficientFunds,
        StolenOrLostCard,
        IssuingBankUnavailable,
        InactiveCard,
        CidDidNotMatch,
        CreditLimit,
        InvalidCvn,
        NegativeFile,
        DidNotPassCvnCheck,
        InvalidAccountNumber,
        CardTypeNotExpected,
        GeneralDeclineByProcessor,
        ProblemWithInformation,
        CaptureAmountExceeds,
        ProcessorFailure,
        AlreadyReversed,
        AlreadyCaptured,
        TransactionAmountMustMatchPreviousAmount,
        CardTypeInvalid,
        RequestIdInvalid,
        NoCorresponding,
        TransactionSettledOrReversed,
        NotVoidable,
        RequestForCaptureThatWasVoided,
        TimeoutAtPaymentProcessor,
        StandAloneCreditsNotAllowed,
        NetworkConnection,
        InvalidToken
    }
}

