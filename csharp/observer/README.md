# Observer Pattern.

Observer Pattern is a way to implement One-Many relationship/dependency between objects. If one object changes the state then all of its dependencies will be notified for these changes.
This is something which we call Publishers-Subscribers model.
1. The Publisher or IObservable register the IObserver or subscriber here.
2. These IObserver are notified when there is a change in the state of IObeservable.
3. The IObservable has method to _register()_ and _unregister()_ the IObserver.