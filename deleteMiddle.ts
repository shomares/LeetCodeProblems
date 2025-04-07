import { ListNode } from "./listNode";
import { createNodeList } from "./reverseBetween";

function deleteMiddle(head: ListNode | null): ListNode | null {
    const currentHead = head

    if (head.next === null) {
        return null
    }
    let middle = head
    let next = head
    let antMiddle: ListNode | null = null



    while (next != null && next.next !== null) {
        antMiddle = middle
        middle = middle.next
        next = next.next?.next
    }

    if (!antMiddle) {
        return currentHead
    }
  
    antMiddle.next = middle.next
    return currentHead
};

function printList(head: ListNode | null) {

    if (head === null) {
        return
    }

    console.log(head.val)
    printList(head.next)

}

const s = deleteMiddle(createNodeList([1]))
printList(s)