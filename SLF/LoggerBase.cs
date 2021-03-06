// SLF.NET - Simple Logging Fa�ade for .NET
// Contact and Information: http://slf.codeplex.com
//
// This library is free software; you can redistribute it and/or
// modify it in any way you see fit as long as this copyright
// notice is not being removed.
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
// THIS COPYRIGHT NOTICE MAY NOT BE REMOVED FROM THIS FILE


using System;
using System.Collections.Generic;

namespace Slf
{
  /// <summary>
  /// Abstract base class which provides most logging method
  /// overloads for an <see cref="ILogger"/> implementation.
  /// </summary>
  public abstract class LoggerBase : ILogger
  {
    /// <summary>
    /// The message to log if a null object is logged.
    /// </summary>
    private const string NullString = "null";
    private readonly Dictionary<string, object> _context;

    public Dictionary<string, object> Context
    {
        get
        {
            return _context;
        }
    }

    /// <summary>
    /// The name of this logger - typically this is written to the 
    /// log itself along with the formatted message.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Constructs a logger instance with the given name.
    /// </summary>
    /// <param name="name">the logger name</param>
    protected LoggerBase(string name)
    {
        _context = new Dictionary<string, object>();
      Name = name;
    }

    /// <summary>
    /// Constructs an un-named logger
    /// </summary>
    protected LoggerBase()
    {
        _context = new Dictionary<string, object>();
    }

    #region Debug

    /// <summary>
    /// Logs an arbitrary object with the <see cref="LogLevel.Debug"/> level. 
    /// </summary>
    /// <param name="obj">The message object to log, which will be converted
    /// into a string during logging.</param>
    public void Debug(object obj)
    {
      if (IsLogLevelEnabled(LogLevel.Debug))
      {
        Log(LogLevel.Debug, obj != null ? obj.ToString() : NullString);
      }
    }


    /// <summary>
    /// Logs a debug message (<see cref="LogLevel.Debug"/>).
    /// </summary>
    /// <param name="message">The message to log.</param>
    public void Debug(string message)
    {
      if (IsLogLevelEnabled(LogLevel.Debug))
      {
        Log(LogLevel.Debug, message);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Debug"/> level. 
    /// </summary>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Debug(string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Debug))
      {
        Log(LogLevel.Debug, format, args);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Debug"/> level. 
    /// </summary>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Debug(IFormatProvider provider, string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Debug))
      {
        Log(LogLevel.Debug, provider, format, args);
      }
    }


    /// <summary>
    /// Logs an exception with a logging level of <see cref="LogLevel.Debug"/>.
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    public void Debug(Exception exception)
    {
      if (IsLogLevelEnabled(LogLevel.Debug))
      {
        Log(LogLevel.Debug, exception);
      }
    }


    /// <summary>
    /// Logs an exception with an additional message with a logging level of
    /// <see cref="LogLevel.Debug"/>.
    /// </summary>
    /// <param name="exception"> The exception to log.</param>
    /// <param name="message">Additional information regarding the
    /// logged exception.</param>
    public void Debug(Exception exception, string message)
    {
      if (IsLogLevelEnabled(LogLevel.Debug))
      {
        Log(LogLevel.Debug, exception, message);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Debug"/> level. 
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Debug(Exception exception, string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Debug))
      {
        Log(LogLevel.Debug, exception, format, args);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Debug"/> level. 
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Debug(Exception exception, string format, IFormatProvider provider, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Debug))
      {
        Log(LogLevel.Debug, exception, provider, format, args);
      }
    }

    #endregion

    #region Info

    /// <summary>
    /// Logs an arbitrary object with the <see cref="LogLevel.Info"/> level. 
    /// </summary>
    /// <param name="obj">The message object to log, which will be converted
    /// into a string during logging.</param>
    public void Info(object obj)
    {
      if (IsLogLevelEnabled(LogLevel.Info))
      {
        Log(LogLevel.Info, obj != null ? obj.ToString() : NullString);
      }
    }


    /// <summary>
    /// Logs an informational message (<see cref="LogLevel.Info"/>).
    /// </summary>
    /// <param name="message">The message to log.</param>
    public void Info(string message)
    {
      if (IsLogLevelEnabled(LogLevel.Info))
      {
        Log(LogLevel.Info, message);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Info"/> level. 
    /// </summary>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Info(string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Info))
      {
        Log(LogLevel.Info, format, args);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Info"/> level. 
    /// </summary>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Info(IFormatProvider provider, string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Info))
      {
        Log(LogLevel.Info, provider, format, args);
      }
    }


    /// <summary>
    /// Logs an exception with a logging level of <see cref="LogLevel.Info"/>.
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    public void Info(Exception exception)
    {
      if (IsLogLevelEnabled(LogLevel.Info))
      {
        Log(LogLevel.Info, exception);
      }
    }


    /// <summary>
    /// Logs an exception with an additional message with a logging level of
    /// <see cref="LogLevel.Info"/>.
    /// </summary>
    /// <param name="exception"> The exception to log.</param>
    /// <param name="message">Additional information regarding the
    /// logged exception.</param>
    public void Info(Exception exception, string message)
    {
      if (IsLogLevelEnabled(LogLevel.Info))
      {
        Log(LogLevel.Info, exception, message);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Info"/> level. 
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Info(Exception exception, string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Info))
      {
        Log(LogLevel.Info, exception, format, args);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Info"/> level. 
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Info(Exception exception, string format, IFormatProvider provider, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Info))
      {
        Log(LogLevel.Info, exception, provider, format, args);
      }
    }

    #endregion

    #region Warn

    /// <summary>
    /// Logs an arbitrary object with the <see cref="LogLevel.Warn"/> level. 
    /// </summary>
    /// <param name="obj">The message object to log, which will be converted
    /// into a string during logging.</param>
    public void Warn(object obj)
    {
      if (IsLogLevelEnabled(LogLevel.Warn))
      {
        Log(LogLevel.Warn, obj != null ? obj.ToString() : NullString);
      }
    }


    /// <summary>
    /// Logs a warning message (<see cref="LogLevel.Warn"/>).
    /// </summary>
    /// <param name="message">The message to log.</param>
    public void Warn(string message)
    {
      if (IsLogLevelEnabled(LogLevel.Warn))
      {
        Log(LogLevel.Warn, message);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Warn"/> level. 
    /// </summary>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Warn(string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Warn))
      {
        Log(LogLevel.Warn, format, args);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Warn"/> level. 
    /// </summary>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Warn(IFormatProvider provider, string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Warn))
      {
        Log(LogLevel.Warn, provider, format, args);
      }
    }


    /// <summary>
    /// Logs an exception with a logging level of <see cref="LogLevel.Warn"/>.
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    public void Warn(Exception exception)
    {
      if (IsLogLevelEnabled(LogLevel.Warn))
      {
        Log(LogLevel.Warn, exception);
      }
    }


    /// <summary>
    /// Logs an exception with an additional message with a logging level of
    /// <see cref="LogLevel.Warn"/>.
    /// </summary>
    /// <param name="exception"> The exception to log.</param>
    /// <param name="message">Additional information regarding the
    /// logged exception.</param>
    public void Warn(Exception exception, string message)
    {
      if (IsLogLevelEnabled(LogLevel.Warn))
      {
        Log(LogLevel.Warn, exception, message);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Warn"/> level. 
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Warn(Exception exception, string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Warn))
      {
        Log(LogLevel.Warn, exception, format, args);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Warn"/> level. 
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Warn(Exception exception, string format, IFormatProvider provider, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Warn))
      {
        Log(LogLevel.Warn, exception, provider, format, args);
      }
    }

    #endregion

    #region Error

    /// <summary>
    /// Logs an arbitrary object with the <see cref="LogLevel.Error"/> level. 
    /// </summary>
    /// <param name="obj">The message object to log, which will be converted
    /// into a string during logging.</param>
    public void Error(object obj)
    {
      if (IsLogLevelEnabled(LogLevel.Error))
      {
        Log(LogLevel.Error, obj != null ? obj.ToString() : NullString);
      }
    }


    /// <summary>
    /// Logs an error message (<see cref="LogLevel.Error"/>).
    /// </summary>
    /// <param name="message">The message to log.</param>
    public void Error(string message)
    {
      if (IsLogLevelEnabled(LogLevel.Error))
      {
        Log(LogLevel.Error, message);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Error"/> level. 
    /// </summary>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Error(string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Error))
      {
        Log(LogLevel.Error, format, args);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Error"/> level. 
    /// </summary>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Error(IFormatProvider provider, string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Error))
      {
        Log(LogLevel.Error, provider, format, args);
      }
    }


    /// <summary>
    /// Logs an exception with a logging level of <see cref="LogLevel.Error"/>.
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    public void Error(Exception exception)
    {
      if (IsLogLevelEnabled(LogLevel.Error))
      {
        Log(LogLevel.Error, exception);
      }
    }


    /// <summary>
    /// Logs an exception with an additional message with a logging level of
    /// <see cref="LogLevel.Error"/>.
    /// </summary>
    /// <param name="exception"> The exception to log.</param>
    /// <param name="message">Additional information regarding the
    /// logged exception.</param>
    public void Error(Exception exception, string message)
    {
      if (IsLogLevelEnabled(LogLevel.Error))
      {
        Log(LogLevel.Error, exception, message);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Error"/> level. 
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Error(Exception exception, string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Error))
      {
        Log(LogLevel.Error, exception, format, args);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Error"/> level. 
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Error(Exception exception, string format, IFormatProvider provider, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Error))
      {
        Log(LogLevel.Error, exception, provider, format, args);
      }
    }

    #endregion

    #region Fatal

    /// <summary>
    /// Logs an arbitrary object with the <see cref="LogLevel.Fatal"/> level. 
    /// </summary>
    /// <param name="obj">The message object to log, which will be converted
    /// into a string during logging.</param>
    public void Fatal(object obj)
    {
      if (IsLogLevelEnabled(LogLevel.Fatal))
      {
        Log(LogLevel.Fatal, obj != null ? obj.ToString() : NullString);
      }
    }


    /// <summary>
    /// Logs a fatal error message (<see cref="LogLevel.Fatal"/>).
    /// </summary>
    /// <param name="message">The message to log.</param>
    public void Fatal(string message)
    {
      if (IsLogLevelEnabled(LogLevel.Fatal))
      {
        Log(LogLevel.Fatal, message);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Fatal"/> level. 
    /// </summary>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Fatal(string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Fatal))
      {
        Log(LogLevel.Fatal, format, args);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Fatal"/> level. 
    /// </summary>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Fatal(IFormatProvider provider, string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Fatal))
      {
        Log(LogLevel.Fatal, provider, format, args);
      }
    }


    /// <summary>
    /// Logs an exception with a logging level of <see cref="LogLevel.Fatal"/>.
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    public void Fatal(Exception exception)
    {
      if (IsLogLevelEnabled(LogLevel.Fatal))
      {
        Log(LogLevel.Fatal, exception);
      }
    }


    /// <summary>
    /// Logs an exception with an additional message with a logging level of
    /// <see cref="LogLevel.Fatal"/>.
    /// </summary>
    /// <param name="exception"> The exception to log.</param>
    /// <param name="message">Additional information regarding the
    /// logged exception.</param>
    public void Fatal(Exception exception, string message)
    {
      if (IsLogLevelEnabled(LogLevel.Fatal))
      {
        Log(LogLevel.Fatal, exception, message);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Fatal"/> level. 
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Fatal(Exception exception, string format, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Fatal))
      {
        Log(LogLevel.Fatal, exception, format, args);
      }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Fatal"/> level. 
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Fatal(Exception exception, string format, IFormatProvider provider, params object[] args)
    {
      if (IsLogLevelEnabled(LogLevel.Fatal))
      {
        Log(LogLevel.Fatal, exception, provider, format, args);
      }
    }

    #endregion

    #region Trace

    /// <summary>
    /// Logs an arbitrary object with the <see cref="LogLevel.Trace"/> level. 
    /// </summary>
    /// <param name="obj">The message object to log, which will be converted
    /// into a string during logging.</param>
    public void Trace(object obj)
    {
        if (IsLogLevelEnabled(LogLevel.Trace))
        {
            Log(LogLevel.Trace, obj != null ? obj.ToString() : NullString);
        }
    }


    /// <summary>
    /// Logs a Trace error message (<see cref="LogLevel.Trace"/>).
    /// </summary>
    /// <param name="message">The message to log.</param>
    public void Trace(string message)
    {
        if (IsLogLevelEnabled(LogLevel.Trace))
        {
            Log(LogLevel.Trace, message);
        }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Trace"/> level. 
    /// </summary>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Trace(string format, params object[] args)
    {
        if (IsLogLevelEnabled(LogLevel.Trace))
        {
            Log(LogLevel.Trace, format, args);
        }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Trace"/> level. 
    /// </summary>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Trace(IFormatProvider provider, string format, params object[] args)
    {
        if (IsLogLevelEnabled(LogLevel.Trace))
        {
            Log(LogLevel.Trace, provider, format, args);
        }
    }


    /// <summary>
    /// Logs an exception with a logging level of <see cref="LogLevel.Trace"/>.
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    public void Trace(Exception exception)
    {
        if (IsLogLevelEnabled(LogLevel.Trace))
        {
            Log(LogLevel.Trace, exception);
        }
    }


    /// <summary>
    /// Logs an exception with an additional message with a logging level of
    /// <see cref="LogLevel.Trace"/>.
    /// </summary>
    /// <param name="exception"> The exception to log.</param>
    /// <param name="message">Additional information regarding the
    /// logged exception.</param>
    public void Trace(Exception exception, string message)
    {
        if (IsLogLevelEnabled(LogLevel.Trace))
        {
            Log(LogLevel.Trace, exception, message);
        }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Trace"/> level. 
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Trace(Exception exception, string format, params object[] args)
    {
        if (IsLogLevelEnabled(LogLevel.Trace))
        {
            Log(LogLevel.Trace, exception, format, args);
        }
    }


    /// <summary>
    /// Logs a formatted message string with the <see cref="LogLevel.Trace"/> level. 
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public void Trace(Exception exception, string format, IFormatProvider provider, params object[] args)
    {
        if (IsLogLevelEnabled(LogLevel.Trace))
        {
            Log(LogLevel.Trace, exception, provider, format, args);
        }
    }

    #endregion

    #region Log

    /// <summary>
    /// Logs a formatted message on a given logging level. 
    /// </summary>
    /// <param name="level">The logging level which is used to indicate severity,
    /// or for filtering the information.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public virtual void Log(LogLevel level, string format, params object[] args)
    {
      Log(level, String.Format(format, args));
    }


    /// <summary>
    /// Logs a formatted message on a given logging level.
    /// </summary>
    /// <param name="level">The logging level which is used to indicate severity,
    /// or for filtering the information.</param>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public virtual void Log(LogLevel level, IFormatProvider provider, string format, params object[] args)
    {
      Log(level, String.Format(provider, format, args));
    }


    /// <summary>
    /// Logs a message on a given logging level.
    /// </summary>
    /// <param name="level">The logging level which is used to indicate severity,
    /// or for filtering the information.</param>
    /// <param name="message"> The message to log.</param>
    public virtual void Log(LogLevel level, string message)
    {
      LogItem item = new LogItem {LogLevel = level, Message = message, LoggerName = Name};
      Log(item);
    }


    /// <summary>
    /// Logs an exception with on a given logging level.
    /// </summary>
    /// <param name="level">The logging level which is used to indicate severity,
    /// or for filtering the information.</param>
    /// <param name="exception">The exception to log.</param>
    public virtual void Log(LogLevel level, Exception exception)
    {
      Log(level, exception, String.Empty);
    }


    /// <summary>
    /// Logs an exception along with a formatted message string on a given logging level.
    /// </summary>
    /// <param name="level">The logging level which is used to indicate severity,
    /// or for filtering the information.</param>
    /// <param name="exception">The exception to log.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public virtual void Log(LogLevel level, Exception exception, string format, params object[] args)
    {
      string message = String.Format(format, args);
      Log(level, exception, message);
    }


    /// <summary>
    /// Logs an exception along with a formatted message string on a given logging level.
    /// </summary>
    /// <param name="level">The logging level which is used to indicate severity,
    /// or for filtering the information.</param>
    /// <param name="exception">The exception to log.</param>
    /// <param name="provider">An <see cref="IFormatProvider"/> which provides
    /// culture-specific formatting capabilities.</param>
    /// <param name="format">A composite format string that contains placeholders for the
    /// arguments.</param>
    /// <param name="args">An <see cref="object"/> array containing zero or more objects
    /// to format.</param>
    public virtual void Log(LogLevel level, Exception exception, IFormatProvider provider, string format,
                            params object[] args)
    {
      string message = String.Format(provider, format, args);
      Log(level, exception, message);
    }


    /// <summary>
    /// Logs an exception along with a message string on a given logging level.
    /// </summary>
    /// <param name="level">The logging level which is used to indicate severity,
    /// or for filtering the information.</param>
    /// <param name="exception"> The exception to log.</param>
    /// <param name="message">Additional information regarding the
    /// logged exception.</param>
    public virtual void Log(LogLevel level, Exception exception, string message)
    {
      LogItem item = new LogItem {LogLevel = level, Message = message, LoggerName = this.Name};
      item.Exception = exception;
      Log(item);
    }

    #endregion

    /// <summary>
    /// Creates a new log entry based on a given log item.
    /// </summary>
    /// <param name="item">Encapsulates logging information.</param>
    /// <exception cref="ArgumentNullException">If <paramref name="item"/>
    /// is a null reference.</exception>
    public abstract void Log(LogItem item);

    /// <summary>
    /// Indicates whether the given log level is
    /// enabled in the underlying logging framework.
    /// </summary>
    /// <param name="level">The log level to query</param>
    /// <returns>Whether the given level is enabled.</returns>
    protected virtual bool IsLogLevelEnabled(LogLevel level)
    {
      return true;
    }

  }
}