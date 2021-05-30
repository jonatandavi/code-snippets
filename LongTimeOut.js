timeOut(minutes, count){
    setTimeout(() => {
        if (minutes != count) {
            count = count + 1;
            this.timeOut(minutes, count)
        } else {
            console.log(`${minutes} minutes passed.`)
            //Call your next function
        }
    }, 60000)
}

this.timeOut(10, 0);//Call like this