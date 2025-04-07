import { ListNode } from "./listNode"


let finalValue: ListNode | null = null
let final: ListNode | null = null

function reverseBtwRecursive(current: ListNode | null, toItem: number, count: number): ListNode {
    if (count === toItem) {
        final = current
        finalValue = current.next
        return current
    }

    //Try to reverse item
    let lastItem = reverseBtwRecursive(current.next, toItem, count + 1);
    current.next = null
    lastItem.next = current;
    return lastItem.next;
}

function reverseBetween(head: ListNode | null, left: number, right: number): ListNode | null {

    finalValue = null;
    final = null
    let dummy = new ListNode();
    dummy.next = head;
    let countLeft = 0;
    let nextItem = dummy;
    let antItem = dummy;
    while (nextItem != null && countLeft < left) {
        antItem = nextItem;
        nextItem = nextItem.next;
        countLeft++;
    }
    const newValue = right - left;
    let last = reverseBtwRecursive(antItem.next, newValue, 0);
    last.next = finalValue;
    antItem.next = final;
    return dummy.next;
};

export function printList(list: ListNode | null) {
    if (list == null) {
        return
    }

    console.log(list.val)
    printList(list.next)
}

export function createNodeList(array: number[]) {
    const head = new ListNode()
    let current = new ListNode()
    head.next = current
    let index = 0
    while (index < array.length) {
        current.val = array[index]

        if (index < array.length - 1) {
            current.next = new ListNode()
            current = current.next
        }

        index++
    }

    return head.next
}




