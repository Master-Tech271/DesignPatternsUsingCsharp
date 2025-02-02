#Behavioural Design Pattern

	#Memento Design Pattern
		-> Memento Design Pattern is used to restore an object to a previous state.
		#When to use Memento Pattern:
			-> So, the memento pattern can be used when you want to produce snapshots of an object's state
			   to be able to restore the object to a previous state. It's a commonly used pattern for implementing
			   the undo feature, and so provides a common solution that a team of developers can quickly understand
			   and get on the same page with.
		#Pros and Cons
			+ You can simplify the originator's code by letting the caretaker maintain the history of the
				originator's state, satisfying the SRP - Single Responsiblity Principle.

			- The app might consume lots of RAM if lots of mementos are created.

	#State Design Pattern
		-> State Design Pattern is allowing the object to behave differently depending on the state that it is.

	#Strategy Design Pattern
		-> It is used to pass the algorithms or behaviour to an object.
			for e.g., we have a video storage class and it has the Store method. so in this method we want to use multiple compressor to compress the video so we have to use lots of switch or if-else condition then save it, by this it break the rules for the OCP (Open Closed Principle). because if we want to add new compressor in the future we need to modify the existing methods.

	#Iteration Design Pattern
		-> It is used to provide a way to iterate over the object without knowing the internal data structure. By using this we can easily change the internal data structure in future without affecting the consumer.

		-> We use this when we have an idea the data structure may change in the future or the class has highly data, so that if there is any need to change it so we can do it without affecting the consumer.