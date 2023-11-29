﻿namespace ClientPost.Data.ValueObject.Common
{
    public class ErrorItem
    {
        public string FieldName { get; set; } = string.Empty;
        public string Error { get; set; } = string.Empty;
        public string? Code { get; set; } = string.Empty;
    }
}
