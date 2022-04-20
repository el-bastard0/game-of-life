﻿using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using ElBastard0.GameOfLife.Utils;

namespace ElBastard0.GameOfLife.Models.Environment
{
    internal class GameField : IGameField<bool>
    {
        private IDictionary<int, IList<bool>> _field;

        public int Width { get; init; }
        public int Height { get; init; }

        public ICollection<int> Keys => _field.Keys;

        public ICollection<IList<bool>> Values => _field.Values;

        public int Count => _field.Count;

        public bool IsReadOnly => _field.IsReadOnly;

        public IList<bool> this[int key] { get => _field[key]; set => _field[key] = value; }

        public GameField(int width = 100, int heigth = 100)
        {
            Width = width;
            Height = heigth;
            _field = new Dictionary<int, IList<bool>>();

            for (int i = 0; i < heigth; i++)
            {
                _field.Add(i, new List<bool>(new bool[width]));
            }
        }

        public void Add(int key, IList<bool> value)
        {
            _field.Add(key, value);
        }

        public bool ContainsKey(int key)
        {
            return _field.ContainsKey(key);
        }

        public bool Remove(int key)
        {
            return _field.Remove(key);
        }

        public bool TryGetValue(int key, [MaybeNullWhen(false)] out IList<bool> value)
        {
            return _field.TryGetValue(key, out value);
        }

        public void Add(KeyValuePair<int, IList<bool>> item)
        {
            _field.Add(item);
        }

        public void Clear()
        {
            _field.Clear();
        }

        public bool Contains(KeyValuePair<int, IList<bool>> item)
        {
            return _field.Contains(item);
        }

        public void CopyTo(KeyValuePair<int, IList<bool>>[] array, int arrayIndex)
        {
            _field.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<int, IList<bool>> item)
        {
            return _field.Remove(item);
        }

        public IEnumerator<KeyValuePair<int, IList<bool>>> GetEnumerator()
        {
            return _field.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void PrintGameField()
        {
            var sb = new StringBuilder();
            var borderX = new string(GameSettings.BorderIcon, Width + 2);
            sb.AppendLine(borderX);
            foreach (var key in _field.Keys)
            {
                sb.Append(GameSettings.BorderIcon);
                foreach (var value in _field[key])
                {
                    sb.Append(value ? GameSettings.AliveIcon : ' ');
                }
                sb.AppendLine(GameSettings.BorderIcon+"");
            }
            sb.Append(borderX);
            
            Console.SetCursorPosition(0,0);
            Console.WriteLine(sb.ToString());
        }

    }
}
