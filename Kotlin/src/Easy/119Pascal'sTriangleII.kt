package Easy

fun getRow(rowIndex: Int): List<Int> {
    var preList=ArrayList<Int>()
    for (i in 0..rowIndex){
        var list=ArrayList<Int>()
        if(i<2){
            for (j in 0..i){
                list.add(1)
            }
        }else{
            list.add(1)
            for(j in 1..(i-1)){
                list.add(preList.get(j)+preList.get(j-1))
            }
            list.add(1)
        }
        preList=list
    }
    return preList
}
