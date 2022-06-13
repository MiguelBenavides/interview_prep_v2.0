
Implement the following interface. 
All methods must run in O(1) time.


interface AllForOne {
  /**
   * Increment the provided key's frequency value by 1.  Or add the key with the frequency 1 if it's not present.
   *
   * Note that the actual frequency value of the key is not necessary to expose to the caller; its value is only kept internally for bookkeeping purposes.
   */
  void incrementKey(String key);  

  /**
   * Decrement the provided key's frequency value by 1.  Or remove the key if its frequency is 1.  Do nothing if the key is not present.
   *
   * Note that the actual frequency value of the key is not necessary to expose to the caller; its value is only kept internally for bookkeeping purposes.
   */
  void decrementKey(String key);
  
  /**
   * Get one of the keys with the max frequency, or empty string if there are no keys.
   */
  String getMaxKey();
   
  /**
   * Get one of the keys with the min frequency, or empty string if there are no keys.
   */
  String getMinKey();
}