using System;
using System.Collections;
using System.Text;

namespace Question
{
    public class Array_And_String
    {

        public Boolean IsUniqueChars_Array(string str)
        {
            if (str.Length > 128)
                return false;
            Boolean[] char_set = new Boolean[128];

            foreach (var charr in str)
            {
                int char_Position = (int)charr;
                if (char_set[char_Position])
                {
                    return false;
                }
                char_set[char_Position] = true;
            }
            return true;
        }

        public Boolean Permutation_Dic(string source, string compare)
        {
            if (source.Length != compare.Length)
                return false;


            Dictionary<char, int> sourceDict = new Dictionary<char, int>();
            foreach (var charr in source)
            {
                if (sourceDict.ContainsKey(charr))
                {
                    sourceDict[charr]++;
                }
                sourceDict.Add(charr, 1);
            }

            foreach (var charr in compare)
            {
                sourceDict[charr]--;
                if (sourceDict[charr] < 0)
                    return false;
            }
            return true;
        }
        public Boolean Permutation_Array(string source, string compare)
        {
            if (source.Length != compare.Length)
                return false;

            int[] char_array = new int[128];

            foreach (var charr in source)
            {
                char_array[(int)charr]++;
            }
            foreach (var charr in compare)
            {
                char_array[(int)charr]--;
                if (char_array[(int)charr] < 0)
                    return false;
            }
            return true;
        }
        public Boolean Permutation_Sort(string source, string compare)
        {
            if (source.Length != compare.Length)
                return false;

            char[] sourceArray = source.ToArray();
            char[] compareArray = compare.ToArray();
            Array.Sort(sourceArray);
            Array.Sort(compareArray);
            return sourceArray.SequenceEqual(compareArray);
        }

        public string ReplaceSpace_Count(char[] source, int arrayLength)
        {
            int count = 0;
            char[] sourceArray = source;
            for (int i = 0; i < arrayLength; i++)
            {
                if (sourceArray[i] == ' ')
                {
                    count++;
                }
            }
            int index = arrayLength + count * 2;
            if (arrayLength < source.Length)
                sourceArray[index] = '\0';

            for (int i = arrayLength - 1; i >= 0; i--)
            {
                if (sourceArray[i] == ' ')
                {
                    sourceArray[index - 1] = '0';
                    sourceArray[index - 2] = '2';
                    sourceArray[index - 3] = '%';
                    index -= 3;
                }
                else
                {
                    sourceArray[index - 1] = sourceArray[i];
                    index--;
                }
            }
            Console.WriteLine(sourceArray);
            return sourceArray.ToString();

        }

        #region isPermutationOfPalindrome
        public Boolean isPermutationOfPalindrome_Dict(string phrase)
        {
            Dictionary<char, int> charDict = new Dictionary<char, int>();
            foreach (var c in phrase)
            {
                char charr = char.ToUpper(c);
                if (char.IsLetter(charr))
                    break;
                if (charDict.ContainsKey(charr))
                {
                    charDict[charr]++;
                }
                else
                {
                    charDict.Add(charr, 1);
                }
            }

            int count = 0;
            foreach (var value in charDict.Values)
            {
                if (value % 2 == 1)
                {
                    count++;
                    if (count > 1)
                        return false;
                }
            }
            return true;
        }

        #region BitVector
        public Boolean isPermutationOfPalindrome_BitVector(string phrase)
        {
            int bitVector = createBitVector(phrase);

            return bitVector == 0 | (bitVector & (bitVector - 1)) == 0;
        }

        private int createBitVector(string phrase)
        {
            int bitVector = 0;
            foreach (var charr in phrase)
            {
                if (char.IsLetter(charr))
                {
                    int index = char.ToUpper(charr) - 'A';
                    bitVector ^= (1 << index);
                }
            }
            return bitVector;
        }

        #endregion
        #endregion


        #region OneEditAway
        #region Three
        public Boolean IsOneEditAway_Three(string source, string compare)
        {
            if (source.Length == compare.Length)
            {
                return oneEditReplace(source, compare);
            }
            else if (source.Length + 1 == compare.Length)
            {
                return oneEditInsert(source, compare);
            }
            else if (source.Length - 1 == compare.Length)
            {
                return oneEditInsert(source, compare);
            }
            return false;
        }

        private Boolean oneEditReplace(string source, string compare)
        {
            Boolean foundDifferent = false;
            char[] firestArray = source.ToArray();
            char[] secondArray = compare.ToArray();
            for (int i = 0; i < firestArray.Length; i++)
            {
                if (firestArray[i] != secondArray[i])
                {
                    if (foundDifferent)
                        return false;

                    foundDifferent = true;
                }
            }
            return true;
        }


        private Boolean oneEditInsert(string source, string compare)
        {
            int index1 = 0, index2 = 0;
            char[] firstArray = source.ToArray();
            char[] secondArray = compare.ToArray();
            while (index1 < firstArray.Length && index2 < secondArray.Length)
            {
                if (firstArray[index1] != secondArray[index2])
                {
                    if (index1 != index2)
                        return false;
                    index1++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }

        #endregion

        #region Merge
        public Boolean IsOneEditAway_Merge(string source, string compare)
        {
            if (Math.Abs(source.Length - compare.Length) > 1)
                return false;
            char[] firestArray = source.Length < compare.Length ? source.ToArray() : compare.ToArray();

            char[] secondArray = source.Length < compare.Length ? compare.ToArray() : source.ToArray();
            int index1 = 0;
            int index2 = 0;
            Boolean foundDifferent = false;
            while (index1 < source.Length && index2 < compare.Length)
            {
                if (firestArray[index1] != secondArray[index2])
                {
                    if (foundDifferent)
                        return false;
                    foundDifferent = true;

                    if (firestArray.Length == secondArray.Length)
                        index1++;
                }
                else
                {
                    index1++;
                }
                index2++;
            }
            return true;
        }
        #endregion

        #endregion


        #region StringCompress

        public string Compress_WithCompare(string source)
        {
            int finalLength = countCompressLength(source);
            Console.WriteLine(finalLength + "-" + source.Length);
            if (finalLength >= source.Length)
                return source;
            int countConsecutive = 0;
            char[] sourceArray = source.ToArray();
            StringBuilder newString = new StringBuilder(finalLength);
            for (int i = 0; i < sourceArray.Length; i++)
            {
                countConsecutive++;

                if (((i + 1) >= sourceArray.Length) || sourceArray[i] != sourceArray[i + 1])
                {
                    newString.Append(sourceArray[i]);
                    newString.Append(countConsecutive);
                    countConsecutive = 0;
                }
            }
            return newString.ToString();
        }

        private int countCompressLength(string source)
        {
            int countLength = 0;
            int countConsecutive = 0;
            char[] sourceArray = source.ToArray();

            for (int i = 0; i < sourceArray.Length; i++)
            {
                countConsecutive++;

                if (((i + 1) >= sourceArray.Length) || sourceArray[i] != sourceArray[i + 1])
                {
                    countLength += 1 + (countConsecutive / 10 + 1);



                    countConsecutive = 0;
                }
            }

            return countLength;
        }

        #endregion


        #region Rotate

        public int[,] Rotate(int[,] matrix)
        {
            Console.WriteLine(matrix.GetLength(1) + "" + matrix.GetLength(0));
            if (matrix.GetLength(0) != matrix.GetLength(1))
                return null;
            int N = matrix.Rank;
            for (int layer = 0; layer < N / 2; layer++)
            {
                int first = layer;
                int last = N - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = matrix[first, i];

                    // 左->上
                    matrix[first, i] = matrix[last - offset, first];

                    // 下 -> 左
                    matrix[last - offset, first] = matrix[last, last - offset];
                    // 右 -> 下
                    matrix[last, last - offset] = matrix[i, last];
                    //上 -> 右
                    matrix[i, last] = top;

                }
            }
            return matrix;
        }
        #endregion


        #region  SetZero

        public int[,] SetZero_BooleanArray(int[,] matrix)
        {
            Boolean[] rowZero = new Boolean[matrix.GetLength(0)];
            Boolean[] columZero = new Boolean[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        rowZero[i] = true;
                        columZero[j] = true;
                    }
                }
            }
            for (int i = 0; i < rowZero.Length; i++)
            {
                if (rowZero[i])
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        matrix[i, j] = 0;
                }
            }
            for (int j = 0; j < columZero.Length; j++)
            {
                if (columZero[j])
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                        matrix[i, j] = 0;
                }
            }
            return matrix;
        }


        #endregion


    }


}
