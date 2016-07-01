# ExtendedSLF

NLOG implementasyonu olan NlogLogger için Context/LogItemProperties yapısı ve Slf.LogLevel.Trace seçeneği dahil edildi.

Örnek:
slfLogger.Context.Add("SessionId", SessionId);
yada
new LogItem() { LogLevel = LogLevel.Trace, Message = "TestData", LogItemProperties = new List<LogItemProperty>() {new LogItemProperty("SessionId",mySessionId)} }

Nlog.confg:fileName="${basedir}/${event-properties:item=SessionId}.log" >


Kaynak:https://slf.codeplex.com 
