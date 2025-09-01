/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
  let result;
  const hashMap = {};
  for(let i = 0; i <= nums.length; i++){
      const num = nums[i]
      const difference = target - num;
      console.log(JSON.stringify(hashMap), difference, num)
      if(difference in hashMap)
          result = [i, hashMap[difference]]
      hashMap[num] = i;
  }
  return result;
};
