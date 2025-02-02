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
