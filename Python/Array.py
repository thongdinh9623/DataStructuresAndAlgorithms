array = [1, 3, 5, 7, 8]

# Tranverse
print("Tranverse an array:")
i = 0
for x in array:
    print(f"array[{i}] = {x}")
    i += 1

# Insertion
print("\nInsert an element to an array's index:")
element = input("Input an element to insert: ")
index = input(f"Input an array's index ([0, {len(array) - 1}]): ")
array.insert(int(index), int(element))
