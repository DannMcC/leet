/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s) {
    const hashMap = {}
    let currentSubstring = ''
    s.split('').map(char => {
        const newSubstring = currentSubstring;
        if (currentSubstring = '') currentSubstring = char;
        else if (!newSubstring.includes(char)) {
            currentSubstring = newSubstring + char
            hashMap[currentSubstring.length] = currentSubstring
        }
        else if (newSubstring.includes(char)) {
            currentSubstring = newSubstring.split(char)[1]
            hashMap[currentSubstring.length] = currentSubstring
        }     
    })
    return Object.keys(hashMap).length -1
};