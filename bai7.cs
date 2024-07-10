using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tạo một Từ điển với khóa là chuỗi và giá trị là số nguyên
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // Thêm một số giá trị cặp khóa vào Từ điển
        dictionary.Add("apple", 1);
        dictionary.Add("banana", 2);
        dictionary.Add("cherry", 3);

        // Sử dụng phương pháp ContainsKey để kiểm tra xem một khóa có tồn tại trong Từ điển hay không
        string keyToCheck = "banana";
        if (dictionary.ContainsKey(keyToCheck))
        {
            Console.WriteLine($"Key '{keyToCheck}' exists in the dictionary.");
        }
        else
        {
            Console.WriteLine($"Key '{keyToCheck}' does not exist in the dictionary.");
        }

        // Sử dụng phương thức TryGetValue để truy xuất giá trị được liên kết với một khóa nhất định một cách an toàn
        string keyToRetrieve = "cherry";
        if (dictionary.TryGetValue(keyToRetrieve, out int value))
        {
            Console.WriteLine($"Value associated with key '{keyToRetrieve}' is {value}.");
        }
        else
        {
            Console.WriteLine($"Key '{keyToRetrieve}' not found in the dictionary.");
        }

        // Sử dụng vòng lặp foreach để lặp qua các mục KeyValuePair<TKey, TValue> trong Từ điển và in chúng
        Console.WriteLine("\nDictionary contents:");
        foreach (KeyValuePair<string, int> kvp in dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}
