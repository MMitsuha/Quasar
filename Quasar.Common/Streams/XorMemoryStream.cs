using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quasar.Common.Streams
{
    public class XorMemoryStream : Stream
    {
        private readonly MemoryStream _innerStream;

        public XorMemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
        {
            _innerStream = new MemoryStream(buffer, index, count, writable, publiclyVisible);
        }

        public override bool CanRead => _innerStream.CanRead;

        public override bool CanSeek => _innerStream.CanSeek;

        public override bool CanWrite => _innerStream.CanWrite;

        public override long Length => _innerStream.Length;

        public override long Position { get => _innerStream.Position; set => _innerStream.Position = value; }

        public override void Flush()
        {
            _innerStream.Flush();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            var ret = _innerStream.Read(buffer, offset, count);

            XorEncrypt.Decrypt(buffer);

            return ret;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return _innerStream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            _innerStream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            XorEncrypt.Encrypt(buffer);

            _innerStream.Write(buffer, offset, count);
        }
    }
}