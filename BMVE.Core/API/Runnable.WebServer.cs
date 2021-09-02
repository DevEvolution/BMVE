using BMVE.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core
{
    public partial class Runnable
    {
        /// <summary>
        /// Запуск слушающего веб-сервера
        /// </summary>
        /// <param name="domain">Доменный адрес сервера</param>
        /// <param name="port">Порт, который будет прослушиваться</param>
        protected void WebServer_Start(string domain, ushort port) => WebServerProxy.WebServer_Start(domain, port);

        /// <summary>
        /// Ожидание следующего запроса и установка контекстов запроса и ответа
        /// </summary>
        protected void WebServer_NextRequest() => WebServerProxy.WebServer_GetNextRequest();

        /// <summary>
        /// Получение адреса запроса относительно веб-сервера
        /// </summary>
        /// <returns>Относительный адрес запроса</returns>
        protected string WebServer_GetRequestUrl() => WebServerProxy.WebServer_GetRequestUrl();

        /// <summary>
        /// Получение полного адреса запроса
        /// </summary>
        /// <returns>Полный адрес запроса</returns>
        protected string WebServer_GetRequestFullUrl() => WebServerProxy.WebServer_GetRequestFullUrl();

        /// <summary>
        /// Получение метода запроса
        /// </summary>
        /// <returns>GET/POST/PATCH и т.п.</returns>
        protected string WebServer_GetRequestMethod() => WebServerProxy.WebServer_GetRequestMethod();

        /// <summary>
        /// Получение обозначения устройства запроса
        /// </summary>
        /// <returns>Обозначение устройства (заголовок UserAgent)</returns>
        protected string WebServer_GetRequestUserAgent() => WebServerProxy.WebServer_GetRequestUserAgent();

        /// <summary>
        /// Получение типа контента запроса
        /// </summary>
        /// <returns>Тип контента (заголовок ContentType)</returns>
        protected string WebServer_GetRequestContentType() => WebServerProxy.WebServer_GetRequestContentType();

        /// <summary>
        /// Получение ключей параметров строки запроса
        /// </summary>
        /// <returns>Ключи параметров строки запроса</returns>
        protected string[] WebServer_GetRequestQueryStringKeys() => WebServerProxy.WebServer_GetRequestQueryStringKeys();

        /// <summary>
        /// Получение значения из строки запроса по ключу
        /// </summary>
        /// <param name="key">Ключ параметра строки запроса</param>
        /// <returns>Значение параметра строки запроса</returns>
        protected string WebServer_GetRequestQueryStringValue(string key) => WebServerProxy.WebServer_GetRequestQueryStringValue(key);

        /// <summary>
        /// Получение ключей параметров в формате FormData
        /// </summary>
        /// <returns>Ключи параметров FormData</returns>
        protected string[] WebServer_GetRequestFormDataKeys() => WebServerProxy.WebServer_GetRequestFormDataKeys();

        /// <summary>
        /// Получение значения из параметров в формате FormData по ключу
        /// </summary>
        /// <param name="key">Ключ параметра FormData</param>
        /// <returns>Значение параметра FormData</returns>
        protected string WebServer_GetRequestFormDataValue(string key) => WebServerProxy.WebServer_GetRequestFormDataValue(key);

        /// <summary>
        /// Чтение тела запроса
        /// </summary>
        /// <returns>Тело запроса в виде массива байт</returns>
        protected byte[] WebServer_ReadRequestBody() => WebServerProxy.WebServer_ReadRequestBody();

        /// <summary>
        /// Чтение тела запроса (результат в виде строки unicode)
        /// </summary>
        /// <returns>Тело запроса в виде строки</returns>
        protected string WebServer_ReadRequestBodyString() => WebServerProxy.WebServer_ReadRequestBodyString();

        /// <summary>
        /// Запись текста в ответ запроса
        /// </summary>
        /// <param name="text">Текст</param>
        protected void WebServer_Write(string text) => WebServerProxy.WebServer_Write(text);

        /// <summary>
        /// Запись текста в ответ запроса с переводом на новую строку
        /// </summary>
        /// <param name="text">Текст</param>
        protected void WebServer_WriteLine(string text) => WebServerProxy.WebServer_WriteLine(text);

        /// <summary>
        /// Отправка ответа
        /// </summary>
        protected void WebServer_SendResponse() => WebServerProxy.WebServer_SendResponse();

        /// <summary>
        /// Отправка ответа с записью текста
        /// </summary>
        /// <param name="text">Текст ответа</param>
        protected void WebServer_SendResponse(string text) => WebServerProxy.WebServer_SendResponse(text);

        /// <summary>
        /// Отправка ответа с записью массива байт в ответ
        /// </summary>
        /// <param name="bytes">Массив байт</param>
        protected void WebServer_SendResponse(byte[] bytes) => WebServerProxy.WebServer_SendResponse(bytes);

        /// <summary>
        /// Установка типа контента ответа (заголовок ContentType)
        /// </summary>
        /// <param name="contentType">Тип контента</param>
        protected void WebServer_SetResponseContentType(string contentType) => WebServerProxy.WebServer_SetResponseContentType(contentType);

        /// <summary>
        /// Получение типа контента ответа (заголовок ContentType)
        /// </summary>
        /// <returns>Тип контента</returns>
        protected string WebServer_GetResponseContentType() => WebServerProxy.WebServer_GetRequestContentType();

        /// <summary>
        /// Установка кода ответа
        /// </summary>
        /// <param name="statusCode">Код ответа</param>
        protected void WebServer_SetResponseStatusCode(ushort statusCode) => WebServerProxy.WebServer_SetResponseStatusCode(statusCode);

        /// <summary>
        /// Получение кода ответа
        /// </summary>
        /// <returns>Код ответа</returns>
        protected ushort WebServer_GetResponseStatusCode() => WebServerProxy.WebServer_GetResponseStatusCode();

        /// <summary>
        /// Кодирование строки для url-запросов
        /// </summary>
        /// <param name="value">Строка</param>
        /// <returns>Закодированная строка</returns>
        protected string WebServer_UrlEncode(string value) => WebServerProxy.WebServer_UrlEncode(value);

        /// <summary>
        /// Декодирование закодированной для url-запросов строки
        /// </summary>
        /// <param name="rawString">Закодированная строка</param>
        /// <returns>Декодированная строка</returns>
        protected string WebServer_UrlDecode(string rawString) => WebServerProxy.WebServer_UrlDecode(rawString);
    }
}
