﻿namespace GalaxyBudsClient.Message.Decoder;

public class GenericResponseParser : BaseMessageParser
{
    public override MsgIds HandledType => MsgIds.RESP;
    public MsgIds MessageId { set; get; }
    public int ResultCode { set; get; }
    public int? ExtraData { set; get; }

    public override void ParseMessage(SppMessage msg)
    {
        if (msg.Id != HandledType)
            return;

        MessageId = (MsgIds) msg.Payload[0];
        ResultCode = msg.Payload[1];
        if (msg.Payload.Length > 2)
        {
            ExtraData = msg.Payload[2];
        }
    }
}