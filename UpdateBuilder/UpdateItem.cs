using System;
using System.Text.Json.Serialization;

namespace UpdateBuilder
{
    /// <summary>
    /// Item de arquivo que compõe a lista/manifesto de atualização.
    /// </summary>
    public class UpdateItem
    {
        [JsonPropertyName("path")]
        public string Path { get; set; } = string.Empty;

        [JsonPropertyName("hash")]
        public string Hash { get; set; } = string.Empty;

        [JsonPropertyName("size")]
        public long Size { get; set; } = 0;

        /// <summary>
        /// Retorna o tamanho formatado em B, KB ou MB para a UI.
        /// </summary>
        [JsonIgnore]
        public string FormattedSize
        {
            get
            {
                if (Size < 1024) return $"{Size} B";
                if (Size < 1024 * 1024) return $"{(Size / 1024.0):F2} KB";
                return $"{(Size / (1024.0 * 1024.0)):F2} MB";
            }
        }

        public UpdateItem Clone()
        {
            return new UpdateItem
            {
                Path = this.Path,
                Hash = this.Hash,
                Size = this.Size
            };
        }
    }
}
