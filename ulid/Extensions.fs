namespace Extensions

open System

module Date =
    type DateTime with
        static member UnixTime =
            Convert.ToInt64 (DateTime.UtcNow.Subtract(DateTime(1970, 1, 1)).TotalSeconds)