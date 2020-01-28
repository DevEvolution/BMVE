﻿using BMVE.Core.Commands;
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
        /// Ожидает нажатия клавиши на клавиатуре
        /// </summary>
        /// <returns>Код нажатой клавиши</returns>
        protected int Input_WaitForKey() => InputProxy.Input_WaitForKey();

        /// <summary>
        /// Проверяет, нажата ли кнопка с указанным кодом
        /// </summary>
        /// <param name="code">Виртуальный код кнопки</param>
        /// <returns>Кнопка нажата/не нажата</returns>
        protected bool Input_IsKeyPressed(int code) => InputProxy.Input_IsKeyPressed(code);

        /// <summary>
        /// Проверяет, нажата ли кнопка "стрелка влево"
        /// </summary>
        /// <returns>Кнопка нажата/не нажата</returns>
        protected bool Input_LeftArrowKeyPressed() => InputProxy.Input_IsKeyPressed(37);

        /// <summary>
        /// Проверяет, нажата ли кнопка "стрелка вправо"
        /// </summary>
        /// <returns>Кнопка нажата/не нажата</returns>
        protected bool Input_RightArrowKeyPressed() => InputProxy.Input_IsKeyPressed(39);

        /// <summary>
        /// Проверяет, нажата ли кнопка "стрелка вверх"
        /// </summary>
        /// <returns>Кнопка нажата/не нажата</returns>
        protected bool Input_UpArrowKeyPressed() => InputProxy.Input_IsKeyPressed(38);

        /// <summary>
        /// Проверяет, нажата ли кнопка "стрелка вниз"
        /// </summary>
        /// <returns>Кнопка нажата/не нажата</returns>
        protected bool Input_DownArrowKeyPressed() => InputProxy.Input_IsKeyPressed(40);

        /// <summary>
        /// Организовывает ввод строки по указанным координатам применяя указанные настройки шрифта
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <returns>Введенный текст</returns>
        protected string Input_ReadString(int x, int y) => InputProxy.Input_ReadString(x, y);

        /// <summary>
        /// Позволяет получить массив всех нажатых в данный момент клавиш, представленных в виде символов
        /// </summary>
        /// <returns>Массив символов всех нажатых в данный момент клавиш</returns>
        protected string[] Input_GetPressedChars() => InputProxy.Input_GetPressedChars();

        /// <summary>
        /// Позволяет получить координату X курсора мыши
        /// </summary>
        /// <returns>Позиция X курсора мыши относительно окна</returns>
        protected int Input_GetMousePositionX() => InputProxy.Input_GetMousePositionX();

        /// <summary>
        /// Позволяет получить координату Y курсора мыши
        /// </summary>
        /// <returns>Позиция Y курсора мыши относительно окна</returns>
        protected int Input_GetMousePositionY() => InputProxy.Input_GetMousePositionY();

        /// <summary>
        /// Проверяет, нажата ли кнопка мыши с указанным кодом
        /// </summary>
        /// <param name="button">Код кнопки мыши</param>
        /// <returns>Кнопка нажата/не нажата</returns>
        protected bool Input_IsMousePressed(int button) => InputProxy.Input_IsMousePressed(button);

        /// <summary>
        /// Проверяет, нажата ли левая кнопка мыши
        /// </summary>
        /// <returns>Кнопка нажата/не нажата</returns>
        protected bool Input_IsLeftMouseButtonPressed() => InputProxy.Input_IsMousePressed(0);

        /// <summary>
        /// Проверяет, нажата ли правая кнопка мыши
        /// </summary>
        /// <returns>Кнопка нажата/не нажата</returns>
        protected bool Input_IsRightMouseButtonPressed() => InputProxy.Input_IsMousePressed(1);

        /// <summary>
        /// Проверяет, нажата ли средняя кнопка мыши
        /// </summary>
        /// <returns>Кнопка нажата/не нажата</returns>
        protected bool Input_IsMiddleMouseButtonPressed() => InputProxy.Input_IsMousePressed(2);

        /// <summary>
        /// Проверяет, нажата ли первая дополнительная кнопка мыши
        /// </summary>
        /// <returns>Кнопка нажата/не нажата</returns>
        protected bool Input_IsXMouseButton1Pressed() => InputProxy.Input_IsMousePressed(3);

        /// <summary>
        /// Проверяет, нажата ли вторая дополнительная кнопка мыши
        /// </summary>
        /// <returns>Кнопка нажата/не нажата</returns>
        protected bool Input_IsXMouseButton2Pressed() => InputProxy.Input_IsMousePressed(4);
    }
}
