using Kmart.Core.Interface;
using Serilog;
using System.Diagnostics;

namespace Kmart.Core.Implementation
{
    public class LongestIncreasingSubsequenceService: ILongestIncreasingSubsequenceService
    {
        private readonly ILogger _logger;
        public LongestIncreasingSubsequenceService(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Convert the space separate string to list of int
        /// </summary>
        /// <param name="stringInput"></param>
        /// <returns></returns>
        public IEnumerable<int> CovertStringToList(string stringInput)
        {
            try
            {
                return stringInput.Split(" ").Select(int.Parse).ToArray();
            }           
            catch (FormatException e)
            {
                _logger.Error("Input string is not in the proper format: {stringInput}, Exception: {message}, StackTrace: {stackTrace}", stringInput, e.Message, e.StackTrace);
                throw new FormatException($"Input string is not in the proper format: {stringInput}, please check the input string once again");
            }
            catch (ArgumentException e)
            {
                _logger.Error("Invalid input string provided: {stringInput}, Exception: {message}, StackTrace: {stackTrace}", stringInput, e.Message, e.StackTrace);
                throw new ArgumentException($"Invalid input string provided: {stringInput}, please check the input string once again");
            }           
            catch (Exception e)
            {
                _logger.Error("Invalid input string provided: {stringInput}, Exception: {message}, StackTrace: {stackTrace}", stringInput, e.Message, e.StackTrace);
                throw new ArgumentException($"Invalid input string provided: {stringInput}, please check the input string once again");
            }
        }
        /// <summary>
        /// Find the first longest increasing subsequence
        /// </summary>
        /// <param name="list">List of integer</param>
        /// <returns>returns the erliest and longest increasing subsequence</returns>
        public string FindLongestIncreasingSubsequence(IList<int> list)
        {
            List<int> longestSequence = new();
            List<int> firstLongestSubSequence = new();
            string longestSubSequence;

            _logger.Information("Processing the give list to find the longest increasing subsequence: {list}", string.Join(" ", list));

            try
            {
                for (var i = 0; i < list.Count; i++)
                {
                    //traverse the sequence until the last element to find the longest sub-sequence
                    if (i != list.Count - 1 && list[i + 1] > list[i])
                    {
                        if (longestSequence.Count == 0)
                        {
                            longestSequence.Add(list[i]);
                        }
                        longestSequence.Add(list[i + 1]);
                    }
                    else
                    {
                        if (firstLongestSubSequence.Count < longestSequence.Count)
                        {
                            firstLongestSubSequence.Clear();
                            firstLongestSubSequence.AddRange(longestSequence);
                        }
                        longestSequence.Clear();
                    }
                }
            }
            catch (Exception e)
            {
                _logger.Error("Some error occured while finding longest increasing subsequence. Exception: {message}, StackTrace: {stackTrace}", e.Message, e.StackTrace);
                throw;
            }

            longestSubSequence = string.Join(" ", firstLongestSubSequence);
            _logger.Information("The longest increasing subsequence is: {longestSubSequence}", longestSubSequence);

            return longestSubSequence;
        }
    }
}