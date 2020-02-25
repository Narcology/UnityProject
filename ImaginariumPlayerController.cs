//code for PlayerController.cs

private void OnObjectTaken(GameObject go)
{
    if (go.name == "Lamp")
    {
        ObjectManager.Instance.DestroyLampItem();
        GameManager.IsLihgtsItemTaken = true;
        inventory.TakeLamp(true);
    }

    if (go.name == "tree_item")
    {
        ObjectManager.Instance.DestroyTreeItem();
        GameManager.IsObjectsItemTaken = true;
        inventory.TakeTree(true);
    }

    if (go.name == "Rainbow")
    {
        ObjectManager.Instance.DestroyColorItem();
        GameManager.IsColorItemTaken = true;
        inventory.TakeRainbow(true);
    }

    if (go.name == "Apple")
    {
        ObjectManager.Instance.DestroyColorItem();
        GameManager.IsPhysicsItemTaken = true;
        inventory.TakeApple(true);
    }

    if (go.name == "Gramophone")
    {
        ObjectManager.Instance.DestroyGramophones();
        GameManager.IsSoundsItemTaken = true;
        inventory.TakeGramophone(true);
    }

    if (go.name == "bird")
    {
        ObjectManager.Instance.DestroyBirdItem();
        GameManager.IsAnimalsItemTaken = true;
        inventory.TakeBird(true);
    }

    if (go.name == "Saw")
    {
        ObjectManager.Instance.DestroySawItem();
        GameManager.IsHumanityItemTaken = true;
        inventory.TakeSaw(true);
    }

}